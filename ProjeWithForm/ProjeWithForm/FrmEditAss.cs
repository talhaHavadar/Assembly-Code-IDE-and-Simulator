using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    public partial class FrmEditAss : Form
    {

        #region variables
        public string text;
        private string OPCODES = "ADD AND CALL COMA EMPTY FULL ORG HLT IN INC JMP LD OR OUT RET SHL SHR ST SUB XOR END";
        private string WORD2 = "00 01 10 11 B R1 R2 R3 R4 HEX DEC BIN I D";
        private string autoCString = "";
        private bool isChanged = false;
        private string FILE_NAME = "";
        private string PATH = "";
        #endregion

        public FrmEditAss(string text, string path)
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable());
            this.text = text;
            PATH = path;
            FILE_NAME = Path.GetFileName(PATH);
            if (!String.IsNullOrWhiteSpace(FILE_NAME))
            {
                lblHeader.Text += " - (" + FILE_NAME + ")";
            }
            scintilla.Lexer = Lexer.Python;

            string keys = OPCODES + " " + WORD2;
            string[] sort = keys.Split(' ');
            Array.Sort(sort);//Sorting keywords
            for (int i = 0; i < sort.Length; i++)
            {
                autoCString += sort[i];//Create a string for auto complete

                if (i != sort.Length - 1)
                {
                    autoCString += " ";
                }
            }

            //Styling text editor..
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.Styles[Style.Default].Bold = true;

            //scintilla.StyleClearAll();
            scintilla.SetKeywords(0, OPCODES);
            scintilla.Styles[Style.Default].ForeColor = Color.Black;
            scintilla.Styles[Style.Python.Word].ForeColor = Color.DarkRed;
            scintilla.SetKeywords(1, WORD2);
            scintilla.Styles[Style.Python.Word2].ForeColor = Color.DarkBlue;
            scintilla.Styles[Style.Python.CommentLine].ForeColor = Color.DarkGreen;
            scintilla.AutoCIgnoreCase = true;
            scintilla.Text = text;
            if (isChanged)
            {
                lblHeader.Text = lblHeader.Text.Remove(lblHeader.Text.Length - 1);
            }
            isChanged = false;
            
        }

        #region headerPanel
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (e.Button == MouseButtons.Left)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        int mouseX;
        int mouseY;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
        #endregion

        #region scintilla

        private void HighlightWord(string text)
        {
            // Indicators 0-7 could be in use by a lexer
            // so we'll use indicator 8 to highlight words.
            const int NUM = 8;

            // Remove all uses of our indicator
            scintilla.IndicatorCurrent = NUM;
            scintilla.IndicatorClearRange(0, scintilla.TextLength);

            // Update indicator appearance
            scintilla.Indicators[NUM].Style = IndicatorStyle.CompositionThin;
            scintilla.Indicators[NUM].ForeColor = Color.Green;
            scintilla.Indicators[NUM].OutlineAlpha = 50;
            scintilla.Indicators[NUM].Alpha = 30;

            // Search the document
            scintilla.TargetStart = 0;
            scintilla.TargetEnd = scintilla.TextLength;
            scintilla.SearchFlags = SearchFlags.None;
            while (scintilla.SearchInTarget(text) != -1)
            {
                // Mark the search results with the current indicator
                scintilla.IndicatorFillRange(scintilla.TargetStart, scintilla.TargetEnd - scintilla.TargetStart);

                // Search the remainder of the document
                scintilla.TargetStart = scintilla.TargetEnd;
                scintilla.TargetEnd = scintilla.TextLength;
            }
        }

        private int maxLineNumberCharLength;
        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            if (!isChanged)
            {
                lblHeader.Text += "*";
            }
            isChanged = true;
            
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;

        }

        private void scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = scintilla.CurrentPosition;
            var wordStartPos = scintilla.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                scintilla.AutoCShow(lenEntered, autoCString);
            }
        }
        #endregion
        private void btFrmClose_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            if (isChanged)
            {
                result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            else
            {
                this.Close();
            }
            
            if (result == DialogResult.Yes)
            {
                //Saving file
                saveToolStripMenuItem_Click(null, null);
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void scintilla_MouseCaptureChanged(object sender, EventArgs e)
        {
            var currentPos = scintilla.CurrentPosition;
            var wordStartPos = scintilla.WordStartPosition(currentPos, true);
            var wordEndPos = scintilla.WordEndPosition(currentPos, true);

            string text = scintilla.GetTextRange(wordStartPos, wordEndPos - wordStartPos);

            if (!String.IsNullOrWhiteSpace(text))
            {
                HighlightWord(text);
            }
            
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(PATH))
            {
                writer.Write(scintilla.Text);
                writer.Close();
                if (isChanged)
                {
                    lblHeader.Text = lblHeader.Text.Remove(lblHeader.Text.Length - 1);
                }
                isChanged = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btFrmClose_Click(null, null);
        }

    }
}

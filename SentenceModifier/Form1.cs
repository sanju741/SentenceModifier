using System;
using System.Windows.Forms;

namespace SentenceModifier
{
    public partial class Form1 : Form
    {
        private static readonly Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paragraph = this.paragraphTextBox.Text;
            string mixingCharacters = this.mixingCharacterTextBox.Text;

            if (string.IsNullOrEmpty(paragraph))
            {
                this.resultTextBox.Text = "Please input text";
                return;
            }

            if (string.IsNullOrEmpty(mixingCharacters))
            {
                this.resultTextBox.Text = "Please input mixing characters";
                return;
            }

            if(!append1CheckBox.Checked && !append2CheckBox.Checked && !append3CheckBox.Checked)
            {
                this.resultTextBox.Text = "Please select the append option";
                return;
            }
            if (!appendBackCheckBox.Checked && !appendFrontCheckBox.Checked)
            {
                this.resultTextBox.Text = "Please select the append option";
                return;
            }

            string[] splitWords = paragraph.Split(' ');
            string result = "";
            foreach (var word in splitWords)
                result += ProcessWord(word, mixingCharacters) + " ";

            this.resultTextBox.Text = result;
        }


        protected string ProcessWord(string word, string mixingCharacters)
        {
            if (word.Length == 1 && !Char.IsLetterOrDigit(char.Parse(word)))
                return word;

            char lastCharacter = word[word.Length-1];

            if(!char.IsLetterOrDigit(lastCharacter))
                word = word.Remove(word.Length - 1);

            string processedWord = "";
            if (append1CheckBox.Checked)
                processedWord = AppendText(word, GetRandomString(mixingCharacters, 1), appendBackCheckBox.Checked);

            else if (append2CheckBox.Checked)
                processedWord = AppendText(word, GetRandomString(mixingCharacters, 2), appendBackCheckBox.Checked);

            else if (append3CheckBox.Checked)
                processedWord = AppendText(word, GetRandomString(mixingCharacters, 3), appendBackCheckBox.Checked);

            if (!char.IsLetterOrDigit(lastCharacter))
               processedWord= processedWord + lastCharacter;

            return processedWord;
        }


        protected string AppendText(string originalWord, string wordToBeAppended, bool isBackAppend)
        {
            if (isBackAppend)
                return originalWord + wordToBeAppended;

            return wordToBeAppended + originalWord;

        }

        protected string GetRandomString(string mixingText, int size)
        {
            string result = "";
            for (int i = 0; i < size; i++)
                result += GetRandomLetter(mixingText);

            return result;
        }

        protected char GetRandomLetter(string mixingText)
        {
            int randomIndex = _random.Next(mixingText.Length);
            return mixingText[randomIndex];
        }




    }
}

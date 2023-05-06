namespace MegaDesk_Ortiz
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuoteForm viewAddQuoteForm = new AddQuoteForm();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotesForm viewSearchQuotesFrom = new SearchQuotesForm();
            viewSearchQuotesFrom.Tag = this;
            viewSearchQuotesFrom.Show(this);
            Hide();
        }

        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotesForm viewViewAllQuotes = new ViewAllQuotesForm();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
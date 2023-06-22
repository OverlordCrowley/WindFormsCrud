namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly postgresContext context;
        private ChessPlayerRepository playerRepository;
        private int IdForDelete = -1;
        private int IdForEdit = -1;
        public Form1(postgresContext context, ChessPlayerRepository playerRepository)
        {
            InitializeComponent();
            this.context = context;
            this.playerRepository = playerRepository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Service.Update(dataGridView1, context);
        }

        private void button_EditClear_Click(object sender, EventArgs e)
        {
            textBox_EditCountry.Text = "";
            textBox_EditSecondName.Text = "";
            textBox_EditRank.Text = "";
            textBox_EditRating.Text = "";
            panel1.Enabled = false;
        }

        private void button_AddClear_Click(object sender, EventArgs e)
        {
            textBox_AddCountry.Text = "";
            textBox_AddSecondName.Text = "";
            textBox_AddRank.Text = "";
            textBox_AddRating.Text = "";
            panel2.Enabled = false;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if(panel2.Enabled == true)
            {
                panel2.Enabled = false;
                return;
            }
            panel2.Enabled = true;
            IdForEdit = -1;
            IdForDelete = -1;
            button_Edit.Enabled = false;
            button_Detele.Enabled = false;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == true || IdForEdit == -1)
            {
                button_EditClear_Click(sender, e);
                panel1.Enabled = false;
                return;
            }
            panel1.Enabled = true;
            var player = playerRepository.GetAll().FirstOrDefault(x => x.Идентификатор == IdForEdit);
            textBox_EditCountry.Text = player.Страна;
            textBox_EditSecondName.Text = player.Фамилия;
            textBox_EditRank.Text = player.Звание;
            textBox_EditRating.Text = player.Рейтинг.ToString();            
        }

        private void button_EditSave_Click(object sender, EventArgs e)
        {
            if(IdForEdit != -1)
            {
                try
                {
                    var player = playerRepository.GetAll().FirstOrDefault(x => x.Идентификатор == IdForEdit);
                    player.Страна = textBox_EditCountry.Text;
                    player.Фамилия = textBox_EditSecondName.Text;
                    player.Звание = textBox_EditRank.Text;
                    player.Рейтинг = Convert.ToInt32(textBox_EditRating.Text);

                    playerRepository.Update(player);
                    dataGridView1.DataSource = Service.Update(dataGridView1, context);
                    button_EditClear_Click(sender, e);
                    IdForEdit = -1;
                    IdForDelete = -1;
                    button_Edit.Enabled = false;
                    button_Detele.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button_AddSave_Click(object sender, EventArgs e)
        {
            try
            {

                var newChessPlayer = new ChessPlayer()
                {
                    Страна = textBox_AddCountry.Text,
                    Фамилия = textBox_AddSecondName.Text,
                    Звание = textBox_AddRank.Text,
                    Рейтинг = Convert.ToInt32(textBox_AddRating.Text)
                };

                playerRepository.Create(newChessPlayer);
                dataGridView1.DataSource = Service.Update(dataGridView1, context);
                button_AddClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button_Detele_Click(object sender, EventArgs e)
        {
            if(IdForDelete != -1)
            {
                var player = playerRepository.GetAll().FirstOrDefault(x => x.Идентификатор == IdForDelete);
                playerRepository.Delete(player);
                dataGridView1.DataSource = Service.Update(dataGridView1, context);
                IdForEdit = -1;
                IdForDelete = -1;
                button_Edit.Enabled = false;
                button_Detele.Enabled = false;
            }           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                button_Detele.Enabled = true;
                button_Edit.Enabled = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                IdForDelete = Convert.ToInt32(selectedRow.Cells["Идентификатор"].Value);
                IdForEdit = Convert.ToInt32(selectedRow.Cells["Идентификатор"].Value);
            }            
        }
    }
}
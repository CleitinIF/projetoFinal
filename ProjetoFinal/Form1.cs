using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        private MySqlConnection mConn;

        private MySqlDataAdapter mAdapter;

        private DataSet mDataSet;

        private DataTable dt;

        private int editingRowId;

        public Form1()
        {
            InitializeComponent();

            this.Text = "To do APP";

            styleDataGridView();

            mConn = new MySqlConnection("Server=54.232.23.77;Database=projeto;Uid=root;Pwd=root;");

            try
            {
                mConn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            updateData();
        }

        private void updateData()
        {
            if (mConn.State == ConnectionState.Open)
            {
                mDataSet = new DataSet();
                mAdapter = new MySqlDataAdapter("SELECT id, title as 'Título', description as 'Descrição' FROM tasks", mConn);
                mAdapter.Fill(mDataSet, "Tasks");

                mDataGrid.DataSource = null;    
                mDataGrid.DataSource = mDataSet;
                mDataGrid.DataMember = "Tasks";

                mDataGrid.Columns["id"].Visible = false;
                mDataGrid.Columns["Descrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dt = mDataGrid.DataSource as DataTable;
            }
        }

        private bool titleIsEmpty()
        {
            String title = mTitle.Text.ToString();

            return String.IsNullOrWhiteSpace(title);
        }

        private void insertRow()
        {
            String title = mTitle.Text.ToString();
            String content = mContent.Text.ToString();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO tasks (title,description) VALUES (@title,@description)", mConn);

            cmd.Parameters.Add("@title", MySqlDbType.VarChar, 254).Value = title;
            cmd.Parameters.Add("@description", MySqlDbType.Text, 4096).Value = content;

            mAdapter.InsertCommand = cmd;
            cmd.ExecuteNonQuery();

        }

        private void updateRow()
        {
            String title = mTitle.Text.ToString();
            String content = mContent.Text.ToString();

            MySqlCommand cmd = new MySqlCommand("UPDATE tasks SET title=@title, description=@description WHERE id=@id", mConn);

            cmd.Parameters.Add("@title", MySqlDbType.VarChar, 254).Value = title;
            cmd.Parameters.Add("@description", MySqlDbType.Text, 4096).Value = content;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = editingRowId;

            mAdapter.UpdateCommand = cmd;
            cmd.ExecuteNonQuery();
        }

        private void deleteRow(int rowId)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tasks WHERE id=@id", mConn);

            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = rowId;
            mAdapter.DeleteCommand = cmd;
            cmd.ExecuteNonQuery();
        }

        private void styleDataGridView()
        {
            mDataGrid.BorderStyle = BorderStyle.None;
            mDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            mDataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            mDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            mDataGrid.EnableHeadersVisualStyles = false;
            mDataGrid.AllowUserToAddRows = false;
            mDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            mDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            mDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            mDataGrid.RowHeadersVisible = false;

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Ações";
            Deletelink.DataPropertyName = "actions";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Apagar";
            Deletelink.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            mDataGrid.Columns.Add(Deletelink);
        }

        private void mSubmit_Click(object sender, EventArgs e)
        {
            if(titleIsEmpty())
            {
                MessageBox.Show("Não é possivel salvar uma tarefa com o título vazio!");
                return;
            }
            if(editingRowId > 0)
            {
                updateRow();
            } else
            {
                insertRow();
            }
            clearForm();
            updateData();
        }

        private void clearForm()
        {
            mTitle.Text = "";
            mContent.Text = "";
        }

        private void mDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editingRowId = int.Parse(mDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            string title = mDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string content = mDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

            mTitle.Text = title;
            mContent.Text = content;
        }

        private void mDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex.ToString() == "0")
            {
                deleteRow(int.Parse(mDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString()));
                clearForm();
                updateData();
            }
        }

        private void mCancel_Click(object sender, EventArgs e)
        {
            editingRowId = 0;
            clearForm();
            updateData();
        }
    }
}

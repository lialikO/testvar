using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testvar
{
    public partial class Form1 : Form
    {
        //Переменная соединения
        MySqlConnection conn;
        //DataAdapter представляет собой объект Command , получающий данные из источника данных.
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных.
        private BindingSource bSource = new BindingSource();
        //DataSet - расположенное в оперативной памяти представление данных, обеспечивающее согласованную реляционную программную 
        //модель независимо от источника данных.DataSet представляет полный набор данных, включая таблицы, содержащие, упорядочивающие 
        //и ограничивающие данные, а также связи между таблицами.
        private DataSet ds = new DataSet();
        //Представляет одну таблицу данных в памяти.
        private DataTable table = new DataTable();
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содердит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        string id_selected_rows = "0";

        private MySqlDataAdapter MyDA1 = new MySqlDataAdapter();
        private BindingSource bSource1 = new BindingSource();
        private DataSet ds1 = new DataSet();
        private DataTable table1 = new DataTable();
        string id_selected_rows1 = "0";

        private MySqlDataAdapter MyDA2 = new MySqlDataAdapter();
        private BindingSource bSource2 = new BindingSource();
        private DataSet ds2 = new DataSet();
        private DataTable table2 = new DataTable();
        string id_selected_rows2 = "0";

        //Переменная для учета выбора тест\вопрос\ответ
        int vibor = 0;

        //Переменные для radiobutton
        int otvCheck1 = 0;
        int otvCheck2 = 0;
        int otvCheck3 = 0;
        int otvCheck4 = 0;



        public Form1()
        {
            InitializeComponent();
        }

        public void GetListTest()
        {
            //Объявление запроса
            string sqlQueryLoadUsers = "SELECT T_Test.idTestov as 'Номер теста',  T_Test.nameTest as 'Название теста' FROM T_Test";

            //Открываем соединение
            conn.Open();
            //Объявляем команду, которая выполнить запрос в соединении conn
            MyDA.SelectCommand = new MySqlCommand(sqlQueryLoadUsers, conn);
            //Заполняем таблицу записями из БД
            MyDA.Fill(table);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource.DataSource = table;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView1.DataSource = bSource;
            //Закрываем соединение
            conn.Close();

            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount;

        }

        public void GetListVop()
        {
            //Объявление запроса
            string sqlQueryLoadUsers = $"SELECT T_Vopros.idVoprosa as 'id Вопроса' , T_Vopros.vopros as 'Вопрос',  T_Vopros.nomerVop as 'Номер вопроса' FROM T_Vopros WHERE T_Vopros.idTest = {id_selected_rows} ";
            //Открываем соединение
            conn.Open();
            //Объявляем команду, которая выполнить запрос в соединении conn
            MyDA1.SelectCommand = new MySqlCommand(sqlQueryLoadUsers, conn);
            //Заполняем таблицу записями из БД
            MyDA1.Fill(table1);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource1.DataSource = table1;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView2.DataSource = bSource1;
            //Закрываем соединение
            conn.Close();

            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView2.RowCount;

        }

        public void GetListOtv()
        {
            //Объявление запроса
            string sqlQueryLoadUsers = $"SELECT T_Otv.idOts as 'id Ответа' , T_Otv.Otv as 'Ответ', T_Otv.verno as 'Верный', T_Otv.idVop as 'Номер вопроса' FROM T_Otv WHERE T_Otv.nTesta = {id_selected_rows}";
            //Открываем соединение
            conn.Open();
            //Объявляем команду, которая выполнить запрос в соединении conn
            MyDA2.SelectCommand = new MySqlCommand(sqlQueryLoadUsers, conn);
            //Заполняем таблицу записями из БД
            MyDA2.Fill(table2);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource2.DataSource = table2;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView3.DataSource = bSource2;
            //Закрываем соединение
            conn.Close();

            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView3.RowCount;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // строка подключения к БД
            string connStr = "server=pma.sdlik.ru;port=62002;user=st_29;database=is_29_EKZ;password=123456789;";
            //Инициализация подключения
            conn = new MySqlConnection(connStr);

            GetListTest();
            GetListVop();
            GetListOtv();

            //GetComboBoxList();


            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;

            dataGridView2.Columns[0].Visible = true;
            dataGridView2.Columns[1].Visible = true;
            dataGridView2.Columns[2].Visible = true;

            dataGridView3.Columns[0].Visible = true;
            dataGridView3.Columns[1].Visible = true;
            dataGridView3.Columns[2].Visible = true;

            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 40;

            dataGridView2.Columns[0].FillWeight = 15;
            dataGridView2.Columns[1].FillWeight = 30;
            dataGridView2.Columns[2].FillWeight = 15;

            dataGridView3.Columns[0].FillWeight = 15;
            dataGridView3.Columns[1].FillWeight = 15;
            dataGridView3.Columns[2].FillWeight = 15;
            dataGridView3.Columns[3].FillWeight = 15;

            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;

            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[2].ReadOnly = true;

            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true;
            dataGridView3.Columns[3].ReadOnly = true;

            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Убираем заголовки строк
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;

            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView2.ColumnHeadersVisible = true;
            dataGridView3.ColumnHeadersVisible = true;

        }

        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
            //Указываем ID выделенной строки в метке
            reload_list();
        }

        public void GetSelectedIDString1()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView2.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows1 = dataGridView2.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
            //MessageBox.Show(id_selected_rows1);
            //Указываем ID выделенной строки в метке
            //reload_list();
        }

        public void GetSelectedIDString2()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView3.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows2 = dataGridView3.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
            //Указываем ID выделенной строки в метке
            //reload_list();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {//Магические строки
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString();
            }


        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                //dataGridView1.CurrentRow.Selected = true;
                dataGridView1.CurrentCell.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString();

            }
        }

        public void reload_list()
        {
            //Чистим виртуальную таблицу
            //table.Clear();
            table1.Clear();
            table2.Clear();
            //Вызываем метод получения записей, который вновь заполнит таблицу
            //GetListTest();
            GetListOtv();
            GetListVop();
        }
        public void reload_listTest()
        {
            //Чистим виртуальную таблицу
            table.Clear();

            //Вызываем метод получения записей, который вновь заполнит таблицу
            GetListTest();

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {//Магические строки
                dataGridView2.CurrentCell = dataGridView2[e.ColumnIndex, e.RowIndex];
                dataGridView2.CurrentRow.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString1();
            }
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dataGridView2.CurrentCell = dataGridView2[e.ColumnIndex, e.RowIndex];
                //dataGridView1.CurrentRow.Selected = true;
                dataGridView2.CurrentCell.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString1();

            }
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {//Магические строки
                dataGridView3.CurrentCell = dataGridView3[e.ColumnIndex, e.RowIndex];
                dataGridView3.CurrentRow.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString2();
            }
        }

        private void dataGridView3_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dataGridView3.CurrentCell = dataGridView3[e.ColumnIndex, e.RowIndex];
                //dataGridView1.CurrentRow.Selected = true;
                dataGridView3.CurrentCell.Selected = true;
                //Метод получения ID выделенной строки в глобальную переменную
                GetSelectedIDString2();

            }
        }


        public void DeletTest(int obDel)
        {
            switch (obDel)
            {
                case 3:
                    string sql_delete_otv = $"DELETE FROM T_Otv WHERE T_Otv.idOts = {id_selected_rows2}";
                    //Посылаем запрос на обновление данных                   
                    MySqlCommand delete_otv = new MySqlCommand(sql_delete_otv, conn);
                    try
                    {
                        conn.Open();
                        delete_otv.ExecuteNonQuery();
                        MessageBox.Show("Удаление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    finally
                    {
                        conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();
                    }

                    break;
                case 2:
                    string sql_delete_vop = $"DELETE FROM T_Vopros WHERE T_Vopros.idVoprosa  = '{id_selected_rows1}'";
                    string sql_delete_otvVop = $"DELETE FROM T_Otv WHERE T_Otv.idVop = {id_selected_rows1}";
                    //Посылаем запрос на обновление данных                   
                    MySqlCommand delete_otvVop = new MySqlCommand(sql_delete_otvVop, conn);
                    MySqlCommand delete_vop = new MySqlCommand(sql_delete_vop, conn);


                    conn.Open();
                    //delete_otvVop.ExecuteNonQuery();

                    try
                    {

                        delete_vop.ExecuteNonQuery();

                        MessageBox.Show("Удаление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    finally
                    {
                        conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();
                    }

                    break;
                case 1:
                    //Формируем строку запроса на добавление строк

                    string sql_delete_test = $"DELETE FROM T_Test WHERE T_Test.idTestov = {id_selected_rows}";
                    string sql_delete_vopTest = $"DELETE FROM T_Vopros WHERE T_Vopros.idTest = {id_selected_rows}";
                    string sql_delete_otvTest = $"DELETE FROM T_Otv WHERE T_Otv.nTesta = {id_selected_rows}";
                    //Посылаем запрос на обновление данных                   
                    MySqlCommand delete_otvTest = new MySqlCommand(sql_delete_otvTest, conn);
                    MySqlCommand delete_vopTest = new MySqlCommand(sql_delete_vopTest, conn);
                    MySqlCommand delete_test = new MySqlCommand(sql_delete_test, conn);

                    conn.Open();
                    delete_otvTest.ExecuteNonQuery();
                    delete_vopTest.ExecuteNonQuery();
                    try
                    {

                        delete_test.ExecuteNonQuery();

                        MessageBox.Show("Удаление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    finally
                    {
                        conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();
                    }

                    break;

            }

        }


        private void удалитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletTest(1);
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletTest(2);
        }

        private void удалитьОтветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletTest(3);
        }

        private void добавитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.TopCenter;
            label2.Visible = true;
            label2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button1.Enabled = true;
            vibor = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (vibor)
            {
                case 3:
                    //Формируем строку запроса на добавление строк


                    string otv1 = textBox5.Text;
                    string otv2 = textBox6.Text;
                    string otv3 = textBox7.Text;
                    string otv4 = textBox8.Text;

                    int idtesta1 = Convert.ToInt32(comboBox1.SelectedValue);
                    string idVop1 = comboBox2.SelectedValue.ToString();


                    string sqlotv1 = $"INSERT INTO T_Otv (Otv, verno, idVop, nTesta) " +
                                  $"VALUES ('{otv1}', '{otvCheck1}', '{idVop1}', '{idtesta1}')";
                    string sqlotv2 = $"INSERT INTO T_Otv (Otv, verno, idVop, nTesta) " +
                                  $"VALUES ('{otv2}', '{otvCheck2}', '{idVop1}', '{idtesta1}')";
                    string sqlotv3 = $"INSERT INTO T_Otv (Otv, verno, idVop, nTesta) " +
                                  $"VALUES ('{otv3}', '{otvCheck3}', '{idVop1}', '{idtesta1}')";
                    string sqlotv4 = $"INSERT INTO T_Otv (Otv, verno, idVop, nTesta) " +
                                  $"VALUES ('{otv4}', '{otvCheck4}', '{idVop1}', '{idtesta1}')";
                    conn.Open();
                    MySqlCommand command1 = new MySqlCommand(sqlotv1, conn);
                    command1.ExecuteNonQuery();
                    command1 = new MySqlCommand(sqlotv2, conn);
                    command1.ExecuteNonQuery();
                    command1 = new MySqlCommand(sqlotv3, conn);
                    command1.ExecuteNonQuery();
                    try
                    {

                        // объект для выполнения SQL-запроса
                        command1 = new MySqlCommand(sqlotv4, conn);
                        // выполняем запрос
                        command1.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Добавление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления пользователя\n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        //conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();

                        label1.Visible = false;
                        label1.Enabled = false;

                        comboBox1.Visible = false;
                        comboBox1.Enabled = false;

                        label3.Visible = false;
                        label3.Enabled = false;

                        comboBox2.Visible = false;
                        comboBox2.Enabled = false;

                        label5.Visible = false;
                        label5.Enabled = false;
                        label6.Visible = false;
                        label6.Enabled = false;
                        label7.Visible = false;
                        label7.Enabled = false;
                        label8.Visible = false;
                        label8.Enabled = false;
                        textBox5.Enabled = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        textBox8.Enabled = false;
                        radioButton1.Visible = false;
                        radioButton1.Enabled = false;
                        radioButton2.Visible = false;
                        radioButton2.Enabled = false;
                        radioButton3.Visible = false;
                        radioButton3.Enabled = false;
                        radioButton4.Visible = false;
                        radioButton4.Enabled = false;


                        button1.Visible = false;
                        button1.Enabled = false;
                    }

                    break;
                case 2:
                    //Формируем строку запроса на добавление строк
                    int nVoprosa = Convert.ToInt32(textBox3.Text);
                    string nameVoprosa = textBox4.Text;
                    int idtesta = Convert.ToInt32(comboBox1.SelectedValue);
                    string idVop = idtesta.ToString() + '-' + nVoprosa.ToString();


                    string sql1 = $"INSERT INTO T_Vopros (idVoprosa, vopros, idTest, nomerVop) " +
                        $"VALUES ('{idVop}', '{nameVoprosa}', '{idtesta}', '{nVoprosa}')";

                    try
                    {
                        conn.Open();
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(sql1, conn);
                        // выполняем запрос
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Добавление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления пользователя\n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        //conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();

                        label1.Visible = false;
                        label1.Enabled = false;

                        comboBox1.Visible = false;
                        comboBox1.Enabled = false;

                        label3.Visible = false;
                        label3.Enabled = false;
                        label4.Visible = false;
                        label4.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        button1.Visible = false;
                        button1.Enabled = false;
                    }

                    break;
                case 1:
                    //Формируем строку запроса на добавление строк
                    int nTesta = Convert.ToInt32(textBox1.Text);
                    string nameTest = textBox2.Text;


                    string sql = $"INSERT INTO T_Test (idTestov, nameTest) " +
                        $"VALUES ('{nTesta}', '{nameTest}')";

                    try
                    {
                        conn.Open();
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        // выполняем запрос
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Добавление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления пользователя\n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        //conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();
                        label1.Visible = false;
                        label1.Enabled = false;
                        label2.Visible = false;
                        label2.Enabled = false;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        button1.Visible = false;
                        button1.Enabled = false;

                    }

                    break;

            }
        }

        public void GetComboBoxList()
        {
            //Формирование списка id тестов
            DataTable list_nomer_testa = new DataTable();
            MySqlCommand list_nTest_command = new MySqlCommand();
            //Открываем соединение
            conn.Open();
            //Формируем столбцы для комбобокса списка ЦП
            list_nomer_testa.Columns.Add(new DataColumn("idTestov", System.Type.GetType("System.Int32")));
            list_nomer_testa.Columns.Add(new DataColumn("nTestov", System.Type.GetType("System.String")));
            //Настройка видимости полей комбобокса
            comboBox1.DataSource = list_nomer_testa;
            comboBox1.DisplayMember = "nTestov";
            comboBox1.ValueMember = "idTestov";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_test = "SELECT T_Test.idTestov FROM T_Test";
            list_nTest_command.CommandText = sql_list_test;
            list_nTest_command.Connection = conn;
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_test_reader;
            try
            {
                //Инициализируем ридер
                list_test_reader = list_nTest_command.ExecuteReader();
                while (list_test_reader.Read())
                {
                    DataRow rowToAdd = list_nomer_testa.NewRow();
                    rowToAdd["idTestov"] = Convert.ToInt32(list_test_reader[0]);
                    rowToAdd["nTestov"] = list_test_reader[0].ToString();
                    list_nomer_testa.Rows.Add(rowToAdd);
                }
                list_test_reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка тестов \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                conn.Close();
            }
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.BottomCenter;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            GetComboBoxList();
            label3.Visible = true;
            label3.Enabled = true;
            label4.Visible = true;
            label4.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button1.Visible = true;
            button1.Enabled = true;
            vibor = 2;

        }

        private void добавитьОтветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.BottomCenter;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            GetComboBoxList();
            label3.Visible = true;
            label3.Enabled = true;
            label3.TextAlign = ContentAlignment.BottomCenter;
            comboBox2.Visible = true;
            comboBox2.Enabled = true;
            GetComboBoxListEVop();
            label5.Visible = true;
            label5.Enabled = true;
            label6.Visible = true;
            label6.Enabled = true;
            label7.Visible = true;
            label7.Enabled = true;
            label8.Visible = true;
            label8.Enabled = true;
            textBox5.Enabled = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox8.Enabled = true;
            radioButton1.Visible = true;
            radioButton1.Enabled = true;
            radioButton2.Visible = true;
            radioButton2.Enabled = true;
            radioButton3.Visible = true;
            radioButton3.Enabled = true;
            radioButton4.Visible = true;
            radioButton4.Enabled = true;

            button1.Visible = true;
            button1.Enabled = true;
            vibor = 3;
        }

        public void GetComboBoxListEVop()
        {
            //Формирование списка статусов
            DataTable list_vop_table = new DataTable();
            MySqlCommand list_vop_command = new MySqlCommand();
            //Открываем соединение
            conn.Open();
            //Формируем столбцы для комбобокса списка ЦП
            list_vop_table.Columns.Add(new DataColumn("nomerVop", System.Type.GetType("System.Int32")));
            list_vop_table.Columns.Add(new DataColumn("idVoprosa", System.Type.GetType("System.String")));
            //Настройка видимости полей комбобокса
            comboBox2.DataSource = list_vop_table;
            comboBox2.DisplayMember = "nomerVop";
            comboBox2.ValueMember = "idVoprosa";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_vop = $"SELECT idVoprosa,  nomerVop FROM T_Vopros WHERE T_Vopros.idTest = {id_selected_rows}";
            list_vop_command.CommandText = sql_list_vop;
            list_vop_command.Connection = conn;
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_vop_reader;
            try
            {
                //Инициализируем ридер
                list_vop_reader = list_vop_command.ExecuteReader();
                while (list_vop_reader.Read())
                {
                    DataRow rowToAdd = list_vop_table.NewRow();
                    rowToAdd["nomerVop"] = Convert.ToInt32(list_vop_reader[1]);
                    rowToAdd["idVoprosa"] = list_vop_reader[0].ToString();
                    list_vop_table.Rows.Add(rowToAdd);
                }
                list_vop_reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка ФИО \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { otvCheck1 = 1; otvCheck2 = 0; otvCheck3 = 0; otvCheck4 = 0; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { otvCheck2 = 1; otvCheck1 = 0; otvCheck3 = 0; otvCheck4 = 0; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { otvCheck3 = 1; otvCheck2 = 0; otvCheck1 = 0; otvCheck4 = 0; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { otvCheck4 = 1; otvCheck2 = 0; otvCheck3 = 0; otvCheck1 = 0; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (vibor)
            {
                case 3:
                    //Формируем строку запроса на добавление строк
                    string otv1 = textBox5.Text;                    
                    int idtesta1 = Convert.ToInt32(comboBox1.SelectedValue);
                    string idVop1 = comboBox2.SelectedValue.ToString();
                    //Строки запросов
                    string sqlotv1 = $"UPDATE T_Otv " +
                        $"SET " +
                        $"Otv = '{otv1}', " +
                        $"verno = '{otvCheck1}', " +
                        $"idVop = '{idVop1}', " +
                        $"nTesta= '{idtesta1}' " +
                        $"WHERE T_Otv.idOts = {id_selected_rows2}";
                    
                    conn.Open();
                    MySqlCommand command1 = new MySqlCommand(sqlotv1, conn);
                    
                    try
                    {

                        // объект для выполнения SQL-запроса
                        command1 = new MySqlCommand(sqlotv1, conn);
                        // выполняем запрос
                        command1.ExecuteNonQuery();
                        
                        MessageBox.Show("Изменение прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения\n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();

                        label1.Visible = false;
                        label1.Enabled = false;

                        comboBox1.Visible = false;
                        comboBox1.Enabled = false;

                        label3.Visible = false;
                        label3.Enabled = false;

                        comboBox2.Visible = false;
                        comboBox2.Enabled = false;

                        label5.Visible = false;
                        label5.Enabled = false;
                        label6.Visible = false;
                        label6.Enabled = false;
                        label7.Visible = false;
                        label7.Enabled = false;
                        label8.Visible = false;
                        label8.Enabled = false;
                        textBox5.Enabled = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        textBox6.Enabled = false;
                        textBox7.Enabled = false;
                        textBox7.Visible = false;
                        textBox8.Visible = false;
                        textBox8.Enabled = false;
                        radioButton1.Visible = false;
                        radioButton1.Enabled = false;
                        radioButton2.Visible = false;
                        radioButton2.Enabled = false;
                        radioButton3.Visible = false;
                        radioButton3.Enabled = false;
                        radioButton4.Visible = false;
                        radioButton4.Enabled = false;


                        button2.Visible = false;
                        button2.Enabled = false;
                    }

                    break;
                case 2:
                    //Формируем строку запроса на добавление строк
                    int nVoprosa = Convert.ToInt32(textBox3.Text);
                    string nameVoprosa = textBox4.Text;
                    int idtesta = Convert.ToInt32(comboBox1.SelectedValue);
                    string idVop = idtesta.ToString() + '-' + nVoprosa.ToString();


                    string sql1 = $"UPDATE T_Vopros " +
                        $"SET " +
                        $"idVoprosa = '{idVop}', " +
                        $"vopros = '{nameVoprosa}', " +
                        $"idTest = '{idtesta}', " +
                        $"nomerVop= '{nVoprosa}' " +
                        $"WHERE T_Vopros.idVoprosa = '{id_selected_rows1}'";

                    try
                    {
                        conn.Open();
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(sql1, conn);
                        // выполняем запрос
                        command.ExecuteNonQuery();
                        //conn.Close();
                        MessageBox.Show("Добавление прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения\n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();

                        label1.Visible = false;
                        label1.Enabled = false;

                        comboBox1.Visible = false;
                        comboBox1.Enabled = false;

                        label3.Visible = false;
                        label3.Enabled = false;
                        label4.Visible = false;
                        label4.Enabled = false;
                        textBox3.Enabled = false;
                        textBox4.Enabled = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        button2.Visible = false;
                        button2.Enabled = false;
                    }

                    break;
                case 1:
                    //Формируем строку запроса на добавление строк
                    int nTesta = Convert.ToInt32(textBox1.Text);
                    string nameTest = textBox2.Text;


                    string sql = $"UPDATE T_Test " +
                        $"SET " +
                        $"idTestov = '{nTesta}', " +
                        $"nameTest = '{nameTest}' " +
                        $"WHERE " +
                        $"idTestov = {id_selected_rows}"; ;

                    try
                    {
                        conn.Open();
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        // выполняем запрос
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Изменение прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload_list();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        //conn.Close();
                        //Вызов метода обновления ДатаГрида
                        reload_list();
                        reload_listTest();
                        label1.Visible = false;
                        label1.Enabled = false;
                        label2.Visible = false;
                        label2.Enabled = false;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        button2.Visible = false;
                        button2.Enabled = false;

                    }

                    break;

            }
        }

        private void изменитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.TopCenter;
            label2.Visible = true;
            label2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            button2.Enabled = true;
            vibor = 1;
        }

        private void изменитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.BottomCenter;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            GetComboBoxList();
            label3.Visible = true;
            label3.Enabled = true;
            label4.Visible = true;
            label4.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
            button2.Enabled = true;
            vibor = 2;
        }

        private void зменитьОтветыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Enabled = true;
            label1.TextAlign = ContentAlignment.BottomCenter;
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
            GetComboBoxList();
            label3.Visible = true;
            label3.Enabled = true;
            label3.TextAlign = ContentAlignment.BottomCenter;
            comboBox2.Visible = true;
            comboBox2.Enabled = true;
            GetComboBoxListEVop();
            label5.Visible = true;
            label5.Enabled = true;
            
            textBox5.Enabled = true;
            textBox5.Visible = true;
            
            radioButton1.Visible = true;
            radioButton1.Enabled = true;
            radioButton2.Visible = true;
            radioButton2.Enabled = true;
            

            button2.Visible = true;
            button2.Enabled = true;
            vibor = 3;
        }
    }
}

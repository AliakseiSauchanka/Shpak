using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
//https://alekseygulynin.ru/vstavka-teksta-v-word-na-c-1-sposob/
//нужно добавить ссылку на Microsoft Word Object Library.
//в документ Word нужно добавить закладки 
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Document doc = null;
            try
            {
                
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = @"e:\Data\Invoice.docx";
                // Открываем
                doc = app.Documents.Add(source);

                //doc = app.Documents.Open(source);
                doc.Activate();

                // Добавляем информацию
                // wBookmarks содержит все закладки
                Word.Bookmarks wBookmarks = doc.Bookmarks;
               
                wBookmarks["Job"].Range.Text = textBox1.Text;
                wBookmarks["Price"].Range.Text = textBox2.Text;
                // Закрываем документ
                doc.SaveAs2(@"e:\Data\invoice_full.docx");
                //doc.PrintOut();
                doc.Close();
                doc = null;
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                if (doc != null)
                {
                    doc.Close();
                    doc = null;
                }
                MessageBox.Show("Во время выполнения произошла ошибка!\n "+ex.Message);
                
            }
        }
    }
}

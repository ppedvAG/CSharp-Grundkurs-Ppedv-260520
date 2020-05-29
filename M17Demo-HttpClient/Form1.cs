using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17Demo_HttpClient
{
    public partial class Form1 : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        static List<Todo> todos;
        public Form1()
        {
            InitializeComponent();
        }
        // async event handler have return type void
        private async void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(httpClient.ToString()); // HttpClient
            HttpResponseMessage response = await httpClient.GetAsync("http://jsonplaceholder.typicode.com/todos");
            string responseBody = await response.Content.ReadAsStringAsync();
            //Console.WriteLine($"responseBody: \n{responseBody}");
            todos = JsonConvert.DeserializeObject<List<Todo>>(responseBody);
            foreach (var item in todos)
            {
                Console.WriteLine(item.id);
                dataGridView1.Rows.Add(item.userId, item.id, item.title, item.completed);
            }
        }

        private class Todo
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show uncompleted            
            List<Todo> uncompletedTodos = (from todo in todos
                                          where todo.completed == false
                                          select todo).ToList();
            //foreach (var item in uncompletedTodos)
            //{
            //    Console.WriteLine(item.id);
            //}
            dataGridView1.Rows.Clear();
            foreach (var item in uncompletedTodos)
            {
                Console.WriteLine(item.id);
                dataGridView1.Rows.Add(item.userId, item.id, item.title, item.completed);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // show todos for user ...
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // show todos for user ...
            if ((sender as TextBox).Text != "")
            {
                List<Todo> userTodos = (from todo in todos
                                        where todo.userId == int.Parse((sender as TextBox).Text)
                                        select todo).ToList();
                dataGridView1.Rows.Clear();
                foreach (var item in userTodos)
                {
                    Console.WriteLine(item.id);
                    dataGridView1.Rows.Add(item.userId, item.id, item.title, item.completed);
                }
            }
            
            
        }
    }
}

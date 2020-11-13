using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Makushkin_EV_11_11_20
{
    public partial class MainForm : Form
    {
        public string FileName { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddOrEditTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTaskTextBox.Text) || DateTime.Now >= DateTimeByExecutePicker.Value)
            {
                MessageBox.Show("Введено некорректное значение даты или названия задачи");
                return;
            }

            if (TaskListViewer.SelectedItems.Count < 1)
            {
                var newTask = new ListViewItem(new string[] { DateTimeByExecutePicker.Value.ToString(), TitleTaskTextBox.Text });
                TaskListViewer.Items.Add(newTask);
            }
            else
            {
                TaskListViewer.SelectedItems[0].SubItems[0].Text = DateTimeByExecutePicker.Value.ToString();
                TaskListViewer.SelectedItems[0].SubItems[1].Text = TitleTaskTextBox.Text;
            }

            DateTimeByExecutePicker.Value = DateTime.Now;
            TitleTaskTextBox.Text = "";
        }

        private void DeleteSelectedTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskListViewer.SelectedItems.Count < 1)
                return;

            TaskListViewer.Items.Remove(TaskListViewer.SelectedItems[0]);
        }

        private void TaskListViewer_Click(object sender, EventArgs e)
        {
            if (TaskListViewer.SelectedItems.Count < 1)
                return;

            DateTimeByExecutePicker.Value = DateTime.Parse(TaskListViewer.SelectedItems[0].SubItems[0].Text);
            TitleTaskTextBox.Text = TaskListViewer.SelectedItems[0].SubItems[1].Text;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            TaskListViewer.Items.Clear();
            FileName = openFileDialog1.FileName;
            
            string[] fileText = File.ReadAllLines(FileName);
            for (int i = 0; i < fileText.Length; i++)
            {
                string[] line = fileText[i].Split('|');
                var newTask = new ListViewItem(new string[] { line[0], line[1]});
                TaskListViewer.Items.Add(newTask);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string savedTaskList = "";
            foreach (ListViewItem item in TaskListViewer.Items)
            {
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    savedTaskList += subitem.Text + " | ";
                }
                savedTaskList += "\n";
            }

            FileName = saveFileDialog1.FileName;
            File.WriteAllText(FileName, savedTaskList);
            MessageBox.Show("Файл сохранен");
        }
    }
}

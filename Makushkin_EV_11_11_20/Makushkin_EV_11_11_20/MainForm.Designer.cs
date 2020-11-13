
namespace Makushkin_EV_11_11_20
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTimeByExecutePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTaskTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrEditTaskButton = new System.Windows.Forms.Button();
            this.DeleteSelectedTaskButton = new System.Windows.Forms.Button();
            this.TaskListViewer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // DateTimeByExecutePicker
            // 
            this.DateTimeByExecutePicker.AllowDrop = true;
            this.DateTimeByExecutePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.DateTimeByExecutePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeByExecutePicker.Location = new System.Drawing.Point(16, 67);
            this.DateTimeByExecutePicker.Name = "DateTimeByExecutePicker";
            this.DateTimeByExecutePicker.Size = new System.Drawing.Size(177, 20);
            this.DateTimeByExecutePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата и время выполнения задачи";
            // 
            // TitleTaskTextBox
            // 
            this.TitleTaskTextBox.Location = new System.Drawing.Point(16, 24);
            this.TitleTaskTextBox.Name = "TitleTaskTextBox";
            this.TitleTaskTextBox.Size = new System.Drawing.Size(177, 20);
            this.TitleTaskTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // AddOrEditTaskButton
            // 
            this.AddOrEditTaskButton.Location = new System.Drawing.Point(16, 274);
            this.AddOrEditTaskButton.Name = "AddOrEditTaskButton";
            this.AddOrEditTaskButton.Size = new System.Drawing.Size(177, 23);
            this.AddOrEditTaskButton.TabIndex = 6;
            this.AddOrEditTaskButton.Text = "Добавить/Редактировать";
            this.AddOrEditTaskButton.UseVisualStyleBackColor = true;
            this.AddOrEditTaskButton.Click += new System.EventHandler(this.AddOrEditTaskButton_Click);
            // 
            // DeleteSelectedTaskButton
            // 
            this.DeleteSelectedTaskButton.Location = new System.Drawing.Point(16, 303);
            this.DeleteSelectedTaskButton.Name = "DeleteSelectedTaskButton";
            this.DeleteSelectedTaskButton.Size = new System.Drawing.Size(177, 23);
            this.DeleteSelectedTaskButton.TabIndex = 7;
            this.DeleteSelectedTaskButton.Text = "Удалить";
            this.DeleteSelectedTaskButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedTaskButton.Click += new System.EventHandler(this.DeleteSelectedTaskButton_Click);
            // 
            // TaskListViewer
            // 
            this.TaskListViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TaskListViewer.FullRowSelect = true;
            this.TaskListViewer.GridLines = true;
            this.TaskListViewer.HideSelection = false;
            this.TaskListViewer.Location = new System.Drawing.Point(199, 13);
            this.TaskListViewer.MultiSelect = false;
            this.TaskListViewer.Name = "TaskListViewer";
            this.TaskListViewer.Size = new System.Drawing.Size(571, 396);
            this.TaskListViewer.TabIndex = 8;
            this.TaskListViewer.UseCompatibleStateImageBehavior = false;
            this.TaskListViewer.View = System.Windows.Forms.View.Details;
            this.TaskListViewer.Click += new System.EventHandler(this.TaskListViewer_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата выполнения задачи";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название задачи";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 400;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(17, 354);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(176, 23);
            this.OpenFileButton.TabIndex = 9;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(17, 383);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(176, 23);
            this.SaveFileButton.TabIndex = 10;
            this.SaveFileButton.Text = "Сохранить";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 444);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.TaskListViewer);
            this.Controls.Add(this.DeleteSelectedTaskButton);
            this.Controls.Add(this.AddOrEditTaskButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimeByExecutePicker);
            this.Name = "MainForm";
            this.Text = "Список дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeByExecutePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTaskTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrEditTaskButton;
        private System.Windows.Forms.Button DeleteSelectedTaskButton;
        private System.Windows.Forms.ListView TaskListViewer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


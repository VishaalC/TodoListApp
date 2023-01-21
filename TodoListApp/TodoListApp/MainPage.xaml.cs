using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void HandleClick(object sender, EventArgs args)
        {
            Console.WriteLine("Clicked");
        }

        public void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);

        }
        public void HandleEnterPress(object sender, EventArgs args)
        {
            Console.WriteLine("Enter Pressed");
            Label newTodo = new Label();
            newTodo.Text = InputField.Text;
            newTodo.FontSize = 20;
            ToDoList.Children.Add(newTodo);
            InputField.Text = "";
        }
    }
}

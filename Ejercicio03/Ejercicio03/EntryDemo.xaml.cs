using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryDemo : ContentPage
    {
        public EntryDemo()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            var entry = new Entry { Text = "This is a read-only Entry" };
            stack.Children.Add(entry);
            Content = stack;
        }
    }
}
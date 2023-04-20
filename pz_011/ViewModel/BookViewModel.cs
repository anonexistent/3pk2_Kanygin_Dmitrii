using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;
using pz_011.Model;

namespace pz_011.ViewModel
{
    class BookViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        ICommand BookCommand { get; set; }
        ICommand BookSelectCommand { get; set; }
        readonly string Path = "books.json";

        public BookViewModel()
        {
            Books = new();

            TestBooks();

            BookCommand = new RelayCommand( (parameter) => true, 
                (parameter) =>
                {
                    var win = parameter as MainWindow;

                    string n = win.tbName.Text;
                    string y = win.tbYear.Text;
                    string a = win.tbAuthor.Text;

                    if(!(string.IsNullOrEmpty(n) && string.IsNullOrEmpty(n) && string.IsNullOrEmpty(a)))
                    {
                        AddBook(n, y, a);
                        win.tbName.Clear();
                        win.tbYear.Clear();
                        win.tbAuthor.Clear();
                    }
                });

            //BookSelectCommand = new RelayCommand((parameter) => true,
            //    (parameter) =>
            //    {
            //        var win = parameter as MainWindow;
            //        win.spNewBook.DataContext = Books;
            //    });
        }

        private void SaveBook()
        {
            File.AppendAllText(Path, new(JsonConvert.SerializeObject(Books)));
        }

        private void LoadBooks()
        {
            if (!File.Exists(Path)) return;

            var books2 = JsonConvert.DeserializeObject<ObservableCollection<Book>>(File.ReadAllText(Path));

            if(books2!=null) foreach(var book in books2) Books.Add(book);
        }

        private void AddBook(string name, string year, string author)
        {
            Books.Add(new(name, year, author));
            LoadBooks();
        }

        void TestBooks()
        {
            Books = new() { new("a","b","c"), new("x", "y", "z"), new("1","2","3"), new("000","001", "010") };
        }
    }
}

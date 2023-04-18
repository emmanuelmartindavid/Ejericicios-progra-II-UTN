using System.Runtime.CompilerServices;

namespace Logic
{
    public class Book
    {
        private List<string> _pages;

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _pages.Count)
                {
                    return _pages[index];
                    
                }
                return "No existe pagina.";

            }
         /*   set
            {
                if (index < 0 || index >= _pages.Count)
                {
                    throw new IndexOutOfRangeException("No extiste pagina.");
                }
                _pages[index] = value;
            }*/

            set
            {
                if( index > _pages.Count ) 
                {
                    _pages.Add( value );
                }
                else if(index >- 0)
                {
                    _pages.Insert( index, value );
                }

            }
        }

       public Book()
        {
            _pages = new List<string>();
        }

       /* public void AddPage(string page)
        {
            _pages.Add(page);
        }

        public override string ToString()
        {
            string result = "";
            foreach (string page in _pages)
            {
                result += page + " ";
            }

            return result;
        }*/
    }


}

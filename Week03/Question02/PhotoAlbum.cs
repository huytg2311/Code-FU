using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum(int i) {
            numberOfPages = i;
        }

        public PhotoAlbum() {
            numberOfPages = 16;
        }

        public int GetNumberOfPages() {
            return numberOfPages;
        }
        
        
    }
}

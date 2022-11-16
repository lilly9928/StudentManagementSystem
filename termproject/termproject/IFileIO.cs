using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termproject
{
    interface IFileIO
    {
        void saveData();
        void readData();

        void ReleaseObject(object obj);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Cola
{
	class Nodo<T>
    {
        public T info;
        public Nodo<T> sgte;
        
        public Nodo()
		{
			info = default(T);
			sgte = null;
		}
        
		public Nodo(T info)
		{
			this.info = info;
			sgte = null;
		}
        
		public T Info 
		{
			get{ return info; }
			set{ info = value; }
		}
        
		public Nodo<T> Sgte
		{
			get{return sgte;}
			set{sgte=value;}
		}
		
    }
}

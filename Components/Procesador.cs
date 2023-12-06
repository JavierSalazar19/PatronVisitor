using PatronVisitor.Component;
using PatronVisitor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor.Components
{
    public class Procesador : Componente
    {
        public Procesador(string serial) : base(serial)
        {

        }

        public override void Aceptar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}

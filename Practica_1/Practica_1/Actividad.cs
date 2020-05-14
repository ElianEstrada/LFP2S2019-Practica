using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Actividad
    {

        private DateTime fecha;
        private String descripcion;
        private String imagenPath;

        public Actividad(DateTime fecha, String descripcion, String imagenPath)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.imagenPath = imagenPath;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public void setDescripción(String descripcion)
        {
            this.descripcion += "\n" + descripcion;
        }

        public void setImagenPath(String imagenPath)
        {
            this.imagenPath = imagenPath;
        }

        public DateTime getFecha() {
            return fecha;
        }

        public String getDescripcion()
        {
            return descripcion;
        }
        
        public String getImagenPath()
        {
            return imagenPath;
        }

    }
}

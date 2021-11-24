using System;
using System.Collections.Generic;
using System.Text;

namespace CourseExercicioPropostoClass05
{
    class Aluno
    {
        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal()
        {
            return PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre;
        }

        public double NotaRestante()
        {
            return  60.00 - NotaFinal();
        }
    }
}

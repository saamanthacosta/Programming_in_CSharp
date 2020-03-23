using System;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            string s = "Certificação C#"; // tipo definido na compilação
            var v = "Certificação C#"; // tipo definido por inferência na compilação
            object o = "Certificação C#"; // tipo definido na compilação

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 127;
            //v = 127;
            o = 127;

            o = (int)o + 4;
            Console.WriteLine(o);

            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 127;
            d = d + 4;
            Console.WriteLine(d);
        }
    }
}

Console.WriteLine(DnaStrand.MakeComplement("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA"));

public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            string dnaFinal = "";
            foreach(char dnaCode in dna)
            {
                switch (dnaCode)
                {
                    case 'A':
                        dnaFinal += 'T';
                    break;
                    case 'T':
                        dnaFinal += 'A';
                    break;
                    case 'C':
                        dnaFinal += 'G';
                    break;
                    case 'G':
                        dnaFinal += 'C';
                    break;
                }
            }
            return dnaFinal;
        }
    }
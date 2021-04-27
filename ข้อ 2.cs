using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool stop = false;
                string DNA;
                Console.Write("Please insert the DNA sequence: ");
                DNA = Console.ReadLine();
                if (IsValidSequence(DNA) == true)
                {
                    Console.WriteLine("Current half sequcence: {0}",DNA);
                   
                    while (true)
                    {
                        Console.Write("Do you want to replicate it ? (Y / N) :  ");
                        string yn = Console.ReadLine();
                        if (yn == "Y")
                        {
                           Console.WriteLine("Current half DNA sequence :{0}", ReplicateSeqeunce(DNA));
                            break;
                        }
                        else if (yn=="N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N");

                     
                        }
                            
                    }
                    
                }
                else
                {
                    Console.WriteLine("The half DNA is invalid");
                }
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
               
                while (true)
                {
                    string answer = Console.ReadLine();
                    if(answer=="Y")
                    {
                        break;
                    }
                    else if(answer=="N")
                    {
                        stop = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        
                    }
                }
                if(stop==true)
                {
                    break;
                }    
               



            }
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;

        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }



    }
}

/* Refactor the following examples to produce code with well-named C# identifiers:
class class_123{
  const int max_count=6;
  class InClass_class_123  {
    void Метод_нА_class_InClass_class_123(bool promenliva)    {
      string promenlivaKatoString=promenliva.ToString();
      Console.WriteLine(promenlivaKatoString);    }
  }    
  public static void Метод_За_Вход()  {
    class_123.InClass_class_123 инстанция =
      new class_123.InClass_class_123();
    инстанция.Метод_нА_class_InClass_class_123(true); 
  }
} */

using System;

public class PrinterData
{
    public const int MaxPagesCount = 6;

    public class InputData
    {
        public static void Main()
        {
            PrinterData.InputData printerDataFromUser = new PrinterData.InputData();
            printerDataFromUser.PrintBooleanValue(true);
        }

        public void PrintBooleanValue(bool isPrinterReadyToPrint)
        {
            string printerStatusAsString = isPrinterReadyToPrint.ToString();
            Console.WriteLine(printerStatusAsString);
        }        
    }
}

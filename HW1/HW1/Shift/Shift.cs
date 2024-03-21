namespace Shift;

public static class Shift
{
    public static int LeftShift(int number, int shift)
    {
       
        
        string binary = Convert.ToString(number, 2);
        string tmp = new string('0', shift);
        string binaryres =binary+tmp;
        if (binary.Length > 16)
        {
             binaryres = binary.Substring(shift);    
        }
        
        return Convert.ToInt32(binaryres, 2);
    }
}
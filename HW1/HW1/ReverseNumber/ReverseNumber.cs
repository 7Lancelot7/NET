using System.Text;




    public static class ReverseNumber
    {
        public static string Reverse(string number)
        {
            if (number is null)
            {
                throw new NullReferenceException("input number is NULL");
            }
            
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(number[i]);
            }

            return stringBuilder.ToString();
        }
    }

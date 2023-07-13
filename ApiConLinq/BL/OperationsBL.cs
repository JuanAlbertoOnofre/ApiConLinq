using System.Net.NetworkInformation;

namespace ApiConLinq.BL
{
    public class OperationsBL
    {
        int[] ints = new int[5] { 1, 2, 3, 4, 5 };

        public async Task<(int StatusCode, int[] ints)> GetArryAsync()
        {
            var res = (from i in ints select i).ToArray();
            if (res != null)
                return (StatusCodes.Status200OK, res);
            return (StatusCodes.Status400BadRequest, new int[0]);
        }
        public async Task<(int StatusCode, string)> GetArryExistAsync(double num)
        {
            var res = (from i in ints where i == num select i ).ToArray();
            if (res != null)
                return (StatusCodes.Status200OK, "Existe");
            return (StatusCodes.Status400BadRequest, "No existe");
        }

        public async Task<(int StatusCode, string)> GetArrayParesAsync()
        {
            var res = (from i in ints select i % 2 == 0).ToArray();
            if (res != null)
                return (StatusCodes.Status200OK, "Existe");
            return (StatusCodes.Status400BadRequest, "No existe");
        }

        public async Task<(int StatusCode, double mult)> MultiplicarAsync(double num1, double num2) 
        {
            double res = (num1 * num2);
            if (res != 0)
                return (StatusCodes.Status200OK, res);
            return (StatusCodes.Status400BadRequest, 0);
        }

        public async Task<(int StatusCode, double mult)> DividirAsync(double num1, double num2)
        {
            double res = (num1 / num2);
            if (res != 0)
                return (StatusCodes.Status200OK, res);
            return (StatusCodes.Status400BadRequest, 0);
        }

    }
}

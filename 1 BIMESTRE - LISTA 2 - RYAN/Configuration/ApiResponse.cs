namespace _1_BIMESTRE___LISTA_2___RYAN.Configuration
{
    public class ApiResponse<T>
    {
        public bool Sucess { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }

    }
}

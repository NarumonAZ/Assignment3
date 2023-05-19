class Program
{

    static void Main(string[] args)
    {
    string plusminusoperator;
    do {
        Console.Write("Input Operator: ");
            plusminusoperator = (Console.ReadLine());
        
        if(plusminusoperator == "+" || plusminusoperator == "-"){
            Console.Write("Input Row Matrix: ");
                int row = int.Parse(Console.ReadLine());
            Console.Write("Input Columns Matrix: ");
                int columns = int.Parse(Console.ReadLine());

        float[,] matrix1 = new float[row,columns];
        float[,] matrix2 = new float[row,columns];
        float[,] matrixAns = new float[row,columns];

        InputMatrix(ref matrix1 ,row ,columns);
        InputMatrix(ref matrix2 ,row ,columns);
        CheckOperator(ref matrixAns ,matrix1 ,matrix2 ,plusminusoperator ,row ,columns);
        PrintMatrix(ref matrixAns,row ,columns);

        }
    }while(plusminusoperator == "+" || plusminusoperator == "-");
}

    static void InputMatrix(ref float[,] matrix ,int row, int columns) {
        for(int i = 0 ; i < row ; i++) {
            for(int j = 0 ; j < columns ; j++){
                matrix[i,j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static void PrintMatrix(ref float[,] matrix ,int row, int columns) {
        for(int i = 0 ; i < row ; i++) {
            for(int j = 0 ; j < columns ; j++){
                Console.Write("{0:0.0} ", matrix[i, j]);
            }
        Console.WriteLine("");
        }
    }

    static void CheckOperator(ref float[,] ans, float[,] num1, float[,] num2, string plusminusoperator,int row, int columns) {
            for(int i = 0 ; i < row ; i++) {
                for(int j = 0 ; j < columns ; j++){
                
                    switch (plusminusoperator){
                        case "+":
                            ans[i, j] = num1[i, j] + num2[i, j];
                        break;

                        case "-":
                            ans[i, j] = num1[i, j] - num2[i, j];
                        break;
                    }

                }
            }
        }

}

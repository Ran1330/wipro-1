#include <stdio.h>
int main()
{
    int  subtract;
    
    printf("Enter two integers\n");
    scanf("%d%d", &first, &second);
    subtract = first - second;
    printf("Difference = %d\n",subtract);
    return 0;
}

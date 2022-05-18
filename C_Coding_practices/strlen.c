# include <stdio.h>
# include <cs50.h>
# include <string.h>

int main(void)
{
    string s = get_string("input:  ");

    int n = strlen(s);
    
    printf("The Name Length is :%i \n",n);



    for (int i = 0; i < strlen(s); i++)
    {
    
        printf("%i characters is: ", i);

        
        printf("%c : %i\n", s[i], s[i]);
    }

}

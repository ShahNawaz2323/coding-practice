//implements the list of numbers using a linked list
#include <cs50.h>
#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
    int number;
    struct node *next;
}
node;

int main(void)
{
    //Memory for number
    node *numbers = NULL;

    //Prompt for numbers until EOF
    while(true)
    {
        //prompt the number
        int number = get_int("number: ");

        //check for EOf
        if (number == INT_MAX)
        {
            break;
        }

        //Allocate space for number
        node *n = malloc(sizeof(node));
        if(!n)
        {
            return 1;
        }

        //Add Number to list
        n->number = number;
        n->next = NULL;
        if(numbers)
        {
            for (node *ptr = numbers; ptr != NULL; ptr = ptr->next)
            {
                if (ptr->next == NULL)
                {
                    ptr->next = n;
                    break;
                }
            }
        }
        else
        {
            numbers = n;
        }

    }
}
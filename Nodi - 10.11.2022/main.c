#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#define MAX 50

typedef struct dipendente
{
    char matricola[5];
    char cognome[MAX];
    int eta;
    struct dipendente *next;

}Dipendenti;

Dipendenti* nuovoDipendente();
Dipendenti* addOnHead(Dipendenti *testa);
Dipendenti* addOnTail(Dipendenti *testa);
int contaNodi(Dipendenti *testa, int cont);
void showList(Dipendenti *testa);

int main()
{
    Dipendenti *testa = NULL;

    srand(time(NULL));

    testa = addOnHead(testa);
    fflush(stdin);
    testa = addOnHead(testa);
    fflush(stdin);
    addOnTail(testa);
    int cont = contaNodi(testa, cont);
    printf("Totale nodi %d\n", cont);

    showList(testa);

    return 0;
}
Dipendenti* nuovoDipendente()
{
    Dipendenti *pDip;
    char matr[5];
    char cogn[MAX];
    int eta, i;
    for(i = 0; i < 2; i++)
        matr[i] = 'A' + rand() % ('A' - 'Z');
    for(i = 2; i < 4; i++)
        matr[i] = '0' + rand() % ('0' + '9');

    printf("Cognome --> ");
    gets(cogn);

    printf("Eta' --> ");
    scanf("%d", &eta);

    pDip = (Dipendenti*) malloc(sizeof(Dipendenti));
    strcpy(pDip->matricola, matr);
    strcpy(pDip->cognome, cogn);
    pDip->eta = eta;
    pDip->next = NULL;

    return pDip;
}

Dipendenti* addOnHead(Dipendenti *testa)
{
    Dipendenti *nodo;

    nodo = nuovoDipendente();

    if(testa == NULL) //se è null vuol dire che non ci sono nodi nella lista
        testa = nodo;
    else //se non è null vuol dire che c'è già un indirizzo
    {
        nodo->next = testa;
        testa = nodo;
    }

    return testa;
}

Dipendenti* addOnTail(Dipendenti *testa)
{
    Dipendenti *nodo, *pLista;

    nodo = nuovoDipendente();
    if(testa == NULL)
        testa = nodo;
    else{
        pLista = testa;

        while(pLista->next != NULL)
            pLista = pLista->next;

        pLista->next = nodo;
    }

    return testa;
}

int contaNodi(Dipendenti *testa, int cont)
{
    while(testa != NULL){
        cont++;
        testa = testa->next;
    }
    return cont;
}

void showList(Dipendenti *testa)
{
    int i = 0;
    while(testa != NULL){
        printf("\nLista nodo %d\n", i);
        printf("Cognome: %s\n", testa->cognome);
        printf("Eta': %d\n", testa->eta);
        testa = testa->next;
        i++;
    }
}

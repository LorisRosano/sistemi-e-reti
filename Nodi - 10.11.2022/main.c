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
Dipendenti* addByPos(Dipendenti *testa);
Dipendenti* delByPos(Dipendenti *testa);
Dipendenti* addOrdinato(Dipendenti *testa);
Dipendenti* sortListByCogn(Dipendenti *testa);
int main()
{
    Dipendenti *testa = NULL;

    srand(time(NULL));

    /*testa = addOnHead(testa);
    fflush(stdin);
    testa = addOnHead(testa);
    fflush(stdin);
    addOnTail(testa);
    fflush(stdin);
    testa = addByPos(testa);
    */

    for(int i = 0; i < 5; i++){
        testa = addOrdinato(testa);
    }
    sortListByCogn(testa);

    int cont = contaNodi(testa, cont);
    printf("Totale nodi %d\n", cont);

    showList(testa);
    delByPos(testa);


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

    eta = rand() % 30;

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
    Dipendenti *pLista;
    pLista = testa;

    while(pLista != NULL){
        cont++;
        pLista = pLista->next;
    }
    return cont;
}

void showList(Dipendenti *testa)
{
    int i = 1;
    Dipendenti *pLista;
    pLista = testa;

    if(pLista == NULL)
        printf("\nLista Vuota.");
    else{
        printf("\nLista Dipendenti\n");
        printf("N. Nodo\tMatr.\tCognome\tEta'\t\n");
        while(pLista != NULL){
        printf("%d\t", i);
        printf("%s\t", pLista->matricola);
        printf("%s\t", pLista->cognome);
        printf("%d\t\n\n", pLista->eta);
        pLista = pLista->next;
        i++;
        }
    }

}

Dipendenti* addByPos(Dipendenti *testa)
{
    int n = 0;
    Dipendenti *pLista;
    pLista = testa;
    printf("Posizione: ");
    scanf("%d", &n);
    int cont = contaNodi(testa, cont);
    if(n <= 1){
        fflush(stdin);
        testa = addOnHead(testa);
    }
    else if(n > cont){
        fflush(stdin);
        testa = addOnTail(testa);
    }

    else{
        fflush(stdin);
        Dipendenti *nodo;
        nodo = nuovoDipendente();
        for(int i = 0; i < n; i++)
            pLista = pLista->next;
        pLista = nodo;
    }
}

Dipendenti* delByPos(Dipendenti *testa)
{
    Dipendenti *pDel, *pPrec;
    int pos = 0, i = 0;
    pPrec = testa;
    printf("Inserisci la pos del nodo da eliminare: ");
    scanf("%d", &pos);

    if (pos == 1){
        pDel = testa;
        testa = testa->next;
    }
    else{
        pPrec = testa;
        for(i = 2; (i < pos) && pDel->next != NULL; i++){
                pPrec = pDel;
                pDel = pDel->next;
        }
        pPrec->next = pDel->next;
    }
    free(pDel);
}

Dipendenti* addOrdinato(Dipendenti *testa)
{
    Dipendenti *nodo;
    Dipendenti *pLista, *pPrec;
    nodo = nuovoDipendente();

    if(testa == NULL)
        testa = nodo;
    else{
        if(strcmp(testa->cognome, nodo->cognome) > 0){
            nodo->next = testa;
            testa = nodo;
        }
        else{
            pPrec = testa;
            pLista = testa->next;
            while(pLista != NULL && strcmp(nodo->cognome, pLista->cognome) > 0){
                pPrec = pLista;
                pLista = pLista->next;
            }
            nodo->next = pLista;
            pPrec->next = nodo;
        }

    }

    return testa;
}

Dipendenti* sortListByCogn(Dipendenti *testa)
{
    int rifare = 1;
    char aus[MAX];
    int ausEta;

    Dipendenti *l1 = NULL;
    Dipendenti *l2 = NULL;
    while(rifare == 1){
        rifare = 0;
        for(l1 = testa; l1->next != NULL; l1 = l1->next){
            for(l2 = l1->next; l2 != NULL; l2 = l2->next){
                if(strcmp(l1->cognome, l2->cognome) > 0){
                    rifare = 1;

                    strcpy(aus, l1->matricola);
                    strcpy(l1->matricola, l2->matricola);
                    strcpy(l2->matricola, aus);

                    strcpy(aus, l1->cognome);
                    strcpy(l1->cognome, l2->cognome);
                    strcpy(l2->cognome, aus);

                    ausEta = l1->eta;
                    l1->eta = l2->eta;
                    l2->eta = ausEta;
                }
            }
        }
    }
}

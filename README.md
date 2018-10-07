# Génération de nombre aléatoire

L’objectif de ce travail est de générer des nombres aléatoires en utilisant différente distributions (uniforme, exponentielle, Pareto) puis, en les affichant afin de pouvoir visualiser le nombre d’occurrence en fonction du tirage.

## Calculs

    Moyenne = somme / nombre d'éléments

    Variance = ((somme^2)/nombre d'éléments) - moyenne(somme)^2

    L’écart-type = sqrt(variance)


## Résultats

Graphique des nombres aléatoires générés en fonction des différentes distributions.

### My random


    rand = (p1 * seed + p2) % n 

![My random](/images/my.png)

### Distribution uniforme


    rand_uniforme = windows random

![Distribution uniforme](/images/uni.png)

### Distribution pareto

    rand_pareto = (1 / (log(1 - rand + 10^-12))) -1

![Distribution pareto](/images/pareto.png)

### Distribution exponentielle

    rand_expo = -log(1 - rand + 10^-12)

![Distribution exponentielle](/images/expo.png)

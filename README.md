# Introduction problématique
Ce README est rédigé dans le cadre du module MA-24 et traitera du projet d'évaluation.
Pour ce projet ma problématique sera les timers en C#, j'ai choisi cette problématique car les timers sont des éléments que je n'ai à mon avis pas bien assimilé lors du module ICT-404 traitant du C#. Ce fichier contiendra des explications à propos des ressources utilisées et comment elles m'ont permis de mener à bien mon projet.
Le programme développé dans le cadre de ce travail sera un simple programme en C# développé sur Visual Studio, il utilisera un timer qui déclenchera des évennements à un moment donné.
Un chrono se lance au lancement de l'application, un message s'affiche toutes les 5 secondes (ou 10 secondes) avertissant depuis combien de temps le programme est lancé. Un bouton Reset permet de remettre le chronomètre à 0 et un bouton Restart permet de le redémarrer.

# Démarche d'apprentissage
Dans cette partie je vais me pencher sur les recherches que j'ai fait et sur les ressources que j'ai utilisées pour m'aider dans les étapes de conception du projet.

## Ressources utilisées
J'ai tout d'abord utilisé le support de cours utilisé pour le module C# ICT-404. Cette ressource contient un petit sous-chapitre sur les timers mais idéal pour moi car il traite de la base des timers. Ce document m'a donc permi d'aborder les timers et de comprendre le fonctionnement de base, j'ai donc pu commencer à les prendre en main sur Visual Studio. Pour résumer cette ressource m'a apporter des connaissances comme: la mise en place du composant timer sur Visual Studio, la propirété Enabled qui permet de soit activer soit désactiver le timer, l'évennement Tick qui est déclenché tous les intervals de secondes ainsi que la propriété Interval qui sert à modifier l'interval entre chaque évennement Tick.
J'ai développé le chronomètre ainsi que les messages qui s'affiche toutes les 5 ou 10 secondes en me basant sur cette ressource.

Chemin de la ressource disponible sur le commun: N:\COMMUN\ELEVE\INFO\SI-CA1a\ICT-404\C#.pdf

Je suis ensuite parti sur internet afin de chercher des informations sur comment remettre un timer à 0, j'y ai trouvé moult manière de faire mais la plupart n'était pas adapté à la conception de mon programme. Mais en continuant à chercher je suis tombé sur une page contenant une capture d'écran de code, je me suis rendu compte en étudiant ce code que la manière utilisé pour mettre le chronomètre à 0 pourrait me servir dans mon programme.
Dans mon application j'utilise la structure TimeSpan qui permet de stocker un interval de temps dans une variable(la variable time), dans mon cas cette variable associer à la structure TimeSpan me permet de stocker la valeur du chrono et cette dernière est mise à jour toutes les 1ms.
La manière utilisé dans ma ressource pour reset le timer est l'utilisation de la propriété .Zero de TimeSpan, cette propriété va mettre la variable associé à TimeSpan a 0. J'ai donc exploité cette propriété dans mon programme, lorsque l'utilisateur clique sur le bouton Reset la variable time est remise à 0 de cette manière: time = TimeSpan.Zero; . Les timers sont ensuite stoppés: timerChrono.Stop(); . La variable time s'affiche au travers du label affichant le chronomètre, elle va donc afficher: 00:00:00:00.

https://markb.uk/creating-a-simple-stopwatchtimer-application-with-c-windows-forms.html

# Tests
Pour tester mon application j'ai uniquement procédé par des tests unitaires, en testant les fonctionnalités au fil du développement. Une fois arrivé à un résultat final j'ai tout simplement lancé le programme et observé que tout se passe comme prévu.

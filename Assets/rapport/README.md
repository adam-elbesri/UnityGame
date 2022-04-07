MOGADE Fabien P1713244
EL BESRI Adam   P1810928
AKSAKAL Hikmet P1709541

Stickman History 
logiciel : Unity
Version : 2019.4.10f1
Sujet : AM3. Développement d'un jeu vidéo 2D sous Unity avec Mister RED
Domaine :	Jeux vidéo
Techniques et langages : C# / Unity
Responsable du sujet : Alexandre Meyer
Difficulté: Raisonnable / Intermédiaire
Style de jeu : Combat/ Street Fighter Like

----------------------------------------------------------------------------------------------

Objectifs : 

Stickman History est un jeu de combat en 3D avec une vue uniquement de coté(2.5D). On peut y jouer à deux (J1 vs J2) ou contre l'ordinateur (J1 vs IA).

Le combat se termine lorsque l'un des joueurs n'a plus de vie ou lorsque le temps arrive à zéro, à ce moment là c'est le joueur avec le plus de vie qui l'emporte.

----------------------------------------------------------------------------------------------

Installation : 

Le jeu n'est pas terminé et quelques bugs subsistent encore.
Il peut être lancer uniquement à partir du Unity Hub avec la version 2019.4.10f1.

Vous pouvez essayer de créer l'exécutable de l'application mais un bug d'affichage sur les personnages persiste.
Pour lancer le jeu une fois tous les dossiers téléchargés. Il vous faudra vérifier que vous êtes bien sur la scène nommée "menu" située dans le dossier "scene" des Assets.
Vous pouvez agrandir la fenêtre game à partir des paramètres de celle-ci sur la droite (3 petits point verticaux).

À partir de ce moment vous pouvez naviguer dans les menus à l'aide de votre souris,
les boutons sont en surbrillance quand vous passez dessus.
Le bouton quitter est programmé pour quitter l'application. Depuis l'interface d'Unity pour quitter le Play Mode il faudrait ajouter la ligne suivante dans le script "UnityEditor.EditorApplication.isPlaying = false;".
Le bouton Option enmène vers une scène incomplète par manque de temps.
Cliquez sur "jouer" , ensuite choisissez votre mode de jeux puis vos personnages ainsi que le décor : Le jeu commence.

Les controle pour le joueur 1 sont les suivant :
    z,q,s,d pour le déplacement
    g,t pour coup de poing
    h,y pour les coup de pied
Les attaques "g,t,h"  sont possible en étant accroupi.

Les controle pour le joueur 2 sont les suivant
    Pavé directionnel pour le déplacement
    "1,4" pour coup de poing
    "2,5" pour les coup de pied
Les attaques "1,4,2"  sont possible en étant accroupi.

Vous pouvez accèder à tout moment au menu pause en appuyant sur la touche échap qui met en pause le jeu.

----------------------------------------------------------------------------------------------

Organisation et explications du code :

Nous avons 5 scènes :  
- ChoixJoueur pour choisir son joueur 
- ChoixMap pour choisir sa carte
- menu qui correspond au menu principal du jeu
- NombreJoueurs qui permet de séléctionner le mode de jeu
- Jeu qui correspond à la scène principale de combat

Concernant les scripts : 
- Un script de colision pour gérer les OnCollision
- Deux scripts gérant les barres de vie des personnages 
- Un script pour que la caméra suive les deux personnages
- Les scripts pour les menus Choix joueur, menu pause , choix map, choix mode de jeu et menu principal
- Un script pour le Timer
- Un script pour le comportement de L'IA
- Un script pour le déplacement
- Un script pour tourner le regard vers l'adversaire peu importe la position 


----------------------------------------------------------------------------------------------

Résultats :

Dans l'état actuel nous avons un jeu de combat avec les éléments suivants :  

- Plusieurs personnages et décors.
- Plusieurs menu animés.
- Deux modes de jeu différents ( J1 VS J2 et J1 VS IA).
- Des collisions fonctionelles et variable selon l'endroit où la collision se produit.
- Un timer de 90 secondes.
- Des barres de vie fonctionnelles.
- Des animations précises et variées pour le déplacement, les attaques, et les états( normal, victoire, mort).
- Une IA peu complexe mais qui fonctionne.
- Des conditions de victoire/défaite.
- Des bruitages

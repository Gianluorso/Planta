# Planta
Web 2d game
Planta
Schermata di login/inserimento singolo nome 
nella quale si potra' scegliere di creare una lobby (con la possibilita' di invitare amici ) o entrare in una lobby tramite link ricevuto.

Schermata di game
nella quale saranno presenti 3 elementi:
-display con l'avanzamento del nostro albero e gli alberi degli avversari
-statistiche luce/acqua/fertilizzante
-scelta dei buff

Display
una volta raggiunte determinate statistiche ( tramite condizioni meteo e scelta dei buff ) il nostro albero crescera' di uno step, una volta raggiunto l'altezza massima si vincera' la partita.
Si potra' vedere anche la condizione meteo che sara' condivisa con gli altri giocatori e cambiera' casualmente ogni X secondi. Sole fara' salire automaticamete la statistica della luce, pioggia quella dell'acqua mentre la luna non alterera' nessun valore.

Statistiche
Le statistiche, se non alterate dal meteo, diminuiscono fino a zero. Per far ottenere uno step al nostro albero tutte e tre le statistiche ( luce, acqua e fertilizzante ) dovranno essere superiori ad una certa soglia (7/10).

Scelta dei buff
Verranno mostrati 3 buff ogni X secondi presi randomicamente da una pool di oggetti, in contemporanea a tutti i giocatori. La pool e' standard per tutti i giocatori. Una volta selezionato il buff desiderato e atteso un tempo prestabilito, il buff andra' a sommarsi alle statistiche di ogni player.
Durante la scelta il tempo di gioco si arresta non alterando le statistiche dei vari giocatori.
Se il giocatore non sceglie entro il tempo prestabilito il buff ne verra' assegnato uno casuale dei 3.
Inoltre ci sara' una barra o timer che evidenziera' il tempo mancante alla successiva scelta del buff/ tempo mancante alla fine della scelta.

Schermata extra:
con istruzioni e leggenda dei vari buff.

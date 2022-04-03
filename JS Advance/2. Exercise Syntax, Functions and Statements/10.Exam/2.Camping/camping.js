class SummerCamp {

    constructor(organizer, location) {
        this.organizer = organizer;
        this.location = location;

        this.listOfParticipants = [];

        this.priceForTheCamp = {
            "child": 150,
            "student": 300,
            "collegian": 500
        }
    }


    registerParticipant(name, condition, money) {
        this.name = name;
        this.condition = condition;
        this.money = money

        if (!this.priceForTheCamp[condition]) {
            throw new Error("Unsuccessful registration at the camp.");
        }

        if (this.priceForTheCamp[condition] > money) {
            return `The money is not enough to pay the stay at the camp.`
        }

        if (this.listOfParticipants.some(x => x.name == name)) {
            return `The ${name} is already registered at the camp.`
        }

        let parcipient = {
            name,
            condition,
            power: 100,
            wins: 0
        }

        this.listOfParticipants.push(parcipient);

        return  `The ${name} was successfully registered.`

    }


    unregisterParticipant(name) {

        //using mutator
        //let index =this.list.findIndex(x=>x.name==name);
        //if(incex==-1){
        //     not registred
        //  }
        // this.listOfParticipants.splice(index,1)

        if (!this.listOfParticipants.some(x => x.name == name)) {
            throw new Error(`The ${name} is not registered in the camp.`);
        }

        //using non motator
        this.listOfParticipants = this.listOfParticipants.filter(x => x.name != name);

        return `The ${name} removed successfully.`

    }


    timeToPlay(typeOfGame, participant1, participant2) {

        let player1 = null;
        let player2 = null;

        if (typeOfGame == 'Battleship') {
            player1 = this.this.listOfParticipants.find(x => x.name == participant1);

            if (!player1) {
                throw Eroor(`Invalid entered name/s.`)
            }

            player1.power += 20;

            return `The ${player1.name} successfully completed the game ${typeOfGame}.`
        } else if (typeOfGame == 'WaterBalloonFights') {

            let nameOfWinner = '';

            player1 = this.this.listOfParticipants.find(x => x.name == participant1);

            if (!player1) {
                throw Eroor(`Invalid entered name/s.`)
            }

            player2 = this.this.listOfParticipants.find(x => x.name == participant2);

            if (!player2) {
                throw Eroor(`Invalid entered name/s.`)
            }

            if (player1.condition != player2.condition) {
                throw Error(`Choose players with equal condition.`)
            }
            if (player1.power > player2.power) {
                player1.power++;
                nameOfWinner = player1.name;
            } else if (player1.power < player2.power) {
                player2.power++;
                nameOfWinner = player2.name;
            } else {
                return `There is no winner.`
            }


            return `The ${nameOfWinner} is winner in the game ${typeOfGame}.`
        }

    }



    toString() {

        console.log(`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);

        this.listOfParticipants.sort((a, b) => b.wins - a.wins).forEach(x => {
            console.log(`${x.name} - ${x.condition} - ${x.power} - ${x.wins}`);
        })
    }
}


const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());





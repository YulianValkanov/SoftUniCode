function calc(array, sorter) {
   
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    
    }

   let newTicketArray=[];
   
    let ticketArr = array;
  
    for (const currentElemetts of ticketArr) {

        let currentArrTickets = currentElemetts.split('|');

        let ticket = new Ticket(currentArrTickets[0], Number(currentArrTickets[1]), currentArrTickets[2]);
        newTicketArray.push(ticket);
    }

   
   return newTicketArray.sort((a,b)=>{
    if (typeof a[sorter]==='number') {
        return a[sorter] - b[sorter];
    }else{
       return a[sorter].localeCompare(b[sorter]);
    }
});
    
}



calc(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination')

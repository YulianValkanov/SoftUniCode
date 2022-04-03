class LibraryCollection {

    constructor(capacity) {
        this.capacity = capacity;

        this.books = [];

    };


    addBook(bookName, bookAuthor) {

        if (this.books.length == this.capacity) {
            throw Error("Not enough space in the collection.");
        };

        let currentBook = {
            bookName,
            bookAuthor,
            payed: false
        };

        this.books.push(currentBook);

        return `The ${bookName}, with an author ${bookAuthor}, collect.`
    };

    payBook(bookName) {

        let searchingBook = this.books.find(x => x.bookName == bookName);

        if (searchingBook == undefined) {
            throw Error(`${bookName} is not in the collection.`)
        };

        if (searchingBook.payed == true) {
            throw Error(`${bookName} has already been paid`)
        };

        searchingBook.payed = true;

        return `${bookName} has been successfully paid.`

    };

    removeBook(bookName) {

        let searchingBook = this.books.find(x => x.bookName == bookName);

        if (searchingBook == undefined) {
            throw Error(`The book, you're looking for, is not found.`)
        };

        if (searchingBook.payed == false) {
            throw Error(`${bookName} need to be paid before removing from the collection.`)
        };

        this.books = this.books.filter(x => x.bookName != bookName);


        return `${bookName} remove from the collection.`
    };

    getStatistics(bookAuthor) {

        let result = [];


        if (bookAuthor == undefined||bookAuthor==null||bookAuthor=='') {

            result.push(`The book collection has ${this.capacity - this.books.length} empty spots left.`);

            this.books.sort((a, b) => {
                return a.bookName.localeCompare(b.bookName);
            })

            for (const book of this.books) {
                let paydOrNot = '';

                if (book.payed == true) {
                    paydOrNot = 'Has Paid';
                } else {
                    paydOrNot = 'Not Paid';
                }

                result.push(`${book.bookName} == ${book.bookAuthor} - ${paydOrNot}.`)
            }
        } else {

            let authorCollection = this.books.filter(x => x.bookAuthor == bookAuthor);

            if (authorCollection.length <= 0) {
                throw Error(`${bookAuthor} is not in the collection.`)
            };

            for (const book of authorCollection) {
                let paydOrNot = '';

                if (book.payed == true) {
                    paydOrNot = 'Has Paid';
                } else {
                    paydOrNot = 'Not Paid';
                }

                result.push(`${book.bookName} == ${book.bookAuthor} - ${paydOrNot}.`);
            }

        }
        return result.join('\n');

    }


}

const library = new LibraryCollection(2)
console.log(library.addBook("Don Quixote", "Miguel de Cervantes"));

console.log(library.getStatistics("Miguel de Cervantes"));










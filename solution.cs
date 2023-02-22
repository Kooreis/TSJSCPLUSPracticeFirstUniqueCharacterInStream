Here is a JavaScript solution using a Map to keep track of the characters and their counts:

```javascript
class UniqueCharFinder {
    constructor() {
        this.map = new Map();
        this.queue = [];
    }

    addChar(c) {
        if (this.map.has(c)) {
            this.map.set(c, this.map.get(c) + 1);
        } else {
            this.map.set(c, 1);
            this.queue.push(c);
        }
    }

    firstUniqueChar() {
        while (this.queue.length > 0) {
            let c = this.queue[0];
            if (this.map.get(c) === 1) {
                return c;
            } else {
                this.queue.shift();
            }
        }
        return null;
    }
}

let finder = new UniqueCharFinder();
let stream = "aabccdeef";
for (let i = 0; i < stream.length; i++) {
    finder.addChar(stream[i]);
    console.log(`First unique character so far is ${finder.firstUniqueChar()}`);
}
```

This script creates a `UniqueCharFinder` class that maintains a map of characters to their counts and a queue of characters. When a character is added with `addChar`, it is added to the map and queue. The `firstUniqueChar` method then checks the queue from the front for the first character that has a count of 1 in the map. If a character has a count greater than 1, it is removed from the queue. The first unique character in the stream is then the character at the front of the queue.
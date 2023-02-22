Here is a TypeScript solution for the problem:

```typescript
class UniqueCharFinder {
    private stream: string[] = [];
    private charCount: { [key: string]: number } = {};

    public addChar(c: string) {
        this.stream.push(c);
        if (this.charCount[c]) {
            this.charCount[c]++;
        } else {
            this.charCount[c] = 1;
        }
    }

    public findFirstUniqueChar(): string | null {
        for (let c of this.stream) {
            if (this.charCount[c] === 1) {
                return c;
            }
        }
        return null;
    }
}

let finder = new UniqueCharFinder();
finder.addChar('a');
finder.addChar('b');
finder.addChar('c');
finder.addChar('a');
finder.addChar('b');
finder.addChar('d');
console.log(finder.findFirstUniqueChar()); // Output: 'c'
```

This solution uses a class `UniqueCharFinder` to keep track of the stream of characters and the count of each character. The `addChar` method is used to add a character to the stream and update the count. The `findFirstUniqueChar` method is used to find the first unique character in the stream.
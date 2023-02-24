public addChar(c: string) {
        this.stream.push(c);
        if (this.charCount[c]) {
            this.charCount[c]++;
        } else {
            this.charCount[c] = 1;
        }
    }
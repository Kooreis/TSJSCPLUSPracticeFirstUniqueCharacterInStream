addChar(c) {
        if (this.map.has(c)) {
            this.map.set(c, this.map.get(c) + 1);
        } else {
            this.map.set(c, 1);
            this.queue.push(c);
        }
    }
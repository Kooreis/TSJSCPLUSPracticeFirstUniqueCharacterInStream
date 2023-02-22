```cpp
#include <iostream>
#include <queue>
#include <unordered_map>

class UniqueCharFinder {
public:
    void insert(char ch) {
        if (charCount.find(ch) == charCount.end()) {
            charQueue.push(ch);
        }
        charCount[ch]++;
    }

    char findFirstUnique() {
        while (!charQueue.empty() && charCount[charQueue.front()] > 1) {
            charQueue.pop();
        }
        if (charQueue.empty()) {
            return '\0';
        }
        return charQueue.front();
    }

private:
    std::queue<char> charQueue;
    std::unordered_map<char, int> charCount;
};

int main() {
    UniqueCharFinder finder;
    std::string stream = "abcabcdfegh";
    for (char ch : stream) {
        finder.insert(ch);
        char uniqueChar = finder.findFirstUnique();
        if (uniqueChar != '\0') {
            std::cout << "First unique character so far is: " << uniqueChar << std::endl;
        } else {
            std::cout << "No unique character found so far." << std::endl;
        }
    }
    return 0;
}
```
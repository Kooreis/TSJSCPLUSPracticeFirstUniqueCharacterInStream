# Question: How can you implement a system to find the first unique character in a stream? JavaScript Summary

The JavaScript code provided creates a system to find the first unique character in a stream of characters. It does this by creating a class called `UniqueCharFinder` that uses a Map to keep track of the count of each character and a queue to maintain the order of the characters. When a character is added to the system using the `addChar` method, it is added to the Map and the queue. The `firstUniqueChar` method then checks the queue from the front for the first character that has a count of 1 in the Map. If a character has a count greater than 1, it is removed from the queue. This process continues until a character with a count of 1 is found or the queue is empty. The first unique character in the stream is then the character at the front of the queue. This system effectively solves the problem by using a Map for efficient lookups and a queue to maintain the order of the characters.

---

# TypeScript Differences

The TypeScript solution is similar to the JavaScript solution in terms of logic and approach. Both solutions use a data structure to keep track of the characters and their counts, and another data structure to keep track of the order of the characters. 

However, there are a few differences:

1. Data Structures: The JavaScript solution uses a Map and an array (queue), while the TypeScript solution uses an array (stream) and an object (charCount).

2. Method Names: The JavaScript solution uses `firstUniqueChar` method to find the first unique character, while the TypeScript solution uses `findFirstUniqueChar`.

3. Type Annotations: The TypeScript solution uses type annotations to specify the types of variables and function return values. For example, `c: string` in the `addChar` method and `string | null` as the return type of the `findFirstUniqueChar` method. This is a feature of TypeScript and is not available in JavaScript.

4. Access Modifiers: The TypeScript solution uses access modifiers (`private` and `public`) to control the visibility of the class properties and methods. This is another feature of TypeScript that is not available in JavaScript.

5. The TypeScript solution directly adds characters to the `UniqueCharFinder` instance one by one, while the JavaScript solution adds characters from a string in a loop.

6. The TypeScript solution finds the first unique character by iterating over the stream array until it finds a character that has a count of 1 in the charCount object. The JavaScript solution, on the other hand, checks and removes characters from the front of the queue until it finds a character that has a count of 1 in the map.

---

# C++ Differences

The C++ version of the solution uses similar logic to the JavaScript version, but with different language-specific features and syntax.

1. Data Structures: Both versions use a queue and a map to keep track of the characters and their counts. In JavaScript, a Map object is used, while in C++, an unordered_map from the Standard Template Library (STL) is used. The queue in JavaScript is implemented using an array with push and shift operations, while in C++, a queue from the STL is used.

2. Class Definition: Both versions define a class `UniqueCharFinder` with similar methods. In JavaScript, the class is defined using the `class` keyword and methods are defined directly within the class. In C++, the class is defined using the `class` keyword, but the methods are defined separately using the scope resolution operator `::`.

3. Method Names: The method names are slightly different. In JavaScript, the methods are `addChar` and `firstUniqueChar`, while in C++, the methods are `insert` and `findFirstUnique`.

4. Checking for Existence in Map: In JavaScript, the `has` method is used to check if a character exists in the map. In C++, the `find` method is used, which returns an iterator to the element if it is found, or an iterator to `unordered_map::end` if not.

5. Handling No Unique Character: In JavaScript, `null` is returned when there is no unique character. In C++, the null character (`'\0'`) is returned.

6. Looping Over the Stream: In JavaScript, a traditional for loop is used to iterate over the stream. In C++, a range-based for loop is used, which is a feature not available in JavaScript.

7. Output: In JavaScript, `console.log` is used to print the output. In C++, `std::cout` is used.

---

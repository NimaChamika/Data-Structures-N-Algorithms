# Data Structures N Algorithms

## 1 - Algorithms

---

### 1 -Search Algos

---

#### 1 - Linear Search

- Simplest method for searching.
- This method can be performed on a sorted or an unsorted list.
- When data is unsorted, a linear search algorithm is preferred.
- Time complexity: O(N)

#### 2 - Binary Search

- List need to be sorted.
- Repeatedly divide the list into parts and check for the element.
- Time Complexity: O(log n)

#### 3 - Jump Search

- List need to be sorted.
- The main idea is to search fewer elements compared to linerar search.This is done by skipping some fixed num of array elements in each iteration.
- optimal jump size is √n.
- Time Complexity: O(√n)
- This is faster than linear search and slower then binary search.
- https://www.studytonight.com/data-structures/jump-search-algorithm

---

### 2 -Sorting Algos

#### 1 - Bubble Sort

- Simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order.
- not good for large data sets.
- Stable
- Time complexity: O(N^2)
- The algo always runs O(N^2) time even if the array is sorted. It can be optimized by stopping the algorithm if the inner loop didn’t cause any swap.

#### 2 - Selection Sort

- This is a simple & efficent sorting algorithm that works by repeatedly selecting the smallest element from the unsorted portion of the list and moving it to the sorted portion of the list.
- not good for large data sets.
- Not stable
- Time complexity: O(N^2)

#### 3 - Insertion Sort

- This is a simple sorting algorithm.
- . The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
- Algorithm works similar to the way you sort playing cards in your hands
- not good for large data sets.
- stable (does not change the relative order of elements with equal keys)
- in-place (only requires a constant amount O(1) of additional memory space)
- Time complexity: O(N^2)

---

## 2- Data Structures

---

## 3 - References

- https://www.geeksforgeeks.org/learn-data-structures-and-algorithms-dsa-tutorial/?ref=ghm

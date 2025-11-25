---
tags:
  - datatypes/collections
---

# Queues (Solutions)

## Multiple Choices

#. A queue is generally endowed with operations called…

    - [ ] Requeue
    - [x] Dequeue
    - [x] Enqueue
    - [ ] Unqueue
        
#. A queue implements which principle?
    
    - [ ] LIFO
    - [x] FIFO 
    - [ ] LILO
    - [ ] FOFI

#. LIFO stands for…

    - [ ] Least Is First Out
    - [ ] Last Is First Outside
    - [x] Last In First Out
    - [ ] Low Input Fast Output

## Exercises

#. Suppose given an empty `Queue` object, and assume that we store the values 10 and 20 (in that order), and then remove one and insert 30. Draw the resulting queue, labelling explicitly the front (or beginning) and end of your queue.

    <details>
    <summary>Solution</summary>
    We get: (end ->) 30 ; 20 (<- front).
    </details>

## Problem

#. This problem is about min-priority queue, i.e., queues where the most important element is the one with the lowest priority. Draw the priority queue after
    
    #. Inserting values with priority 10, 2, 5, 7,
    #. Removing the most important element,
    #. Inserting values with priority 3, 12,
    
    (you can either draw the queue after each step, or only at the very end)      
    
    #. If the queue is implemented using an array.
    
        <details>
        <summary>Solution</summary>
        
        This is supposing an implementation [like the one shared in class](./lectures/data/priority_queue#using-arrays).      
        We decompose each step:
        
        1. Insert value with priority 10
        2. Insert value with priority 2
        3. Insert value with priority 5
        4. Insert value with priority 7
        5. Remove value with priority 2 (the lowest in the queue)
        6. Insert value with priority 3
        7. Insert value with priority 12
        
        <summary>Solution</summary>
        Step  \\ Index | 0      | 1      | 2      | 3      | 4      | 5      | 
          :---        | ---    | ---    | ---    | ---    | ---    | ---    |   
           1          | 10    | `null` | `null` | `null` | `null` | `null` |
           2          | 10    |  2     | `null` | `null` | `null` | `null` | 
           3          | 10    |  2     | 5      | `null` | `null` | `null` |
           4          | 10    |  2     | 5      | 7      | `null` | `null` | 
           5          | 10    | `null` | 5      | 7      | `null` | `null` |  
           6          | 10    | 3      | 5      | 7      | `null` | `null` |
           7          | 10    | 3      | 5      | 7      | 12     | `null` |       
        </details>    
    
    #. If the queue is implemented using a binary heap.
    
        <details>
        <summary>Solution</summary>
        
        This is supposing an implementation [like the one shared in class](./lectures/data/priority_queue#using-heaps).      
        We decompose each step:
        
        1. Insert value with priority 10
        2. Insert value with priority 2
        3. Insert value with priority 5
        4. Insert value with priority 7
        5. Remove value with priority 2 (the lowest in the queue)
        6. Insert value with priority 3
        7. Insert value with priority 12
        
        <summary>Solution</summary>
        Step  \\ Index | 0       | 1      | 2      | 3      | 4      | 5      | 
          :---        | ---    | ---    | ---    | ---    | ---    | ---    |   
           1           | 10      | `null` | `null` | `null` | `null` | `null` |  
           2           | 2       | 10     | `null` | `null` | `null` | `null` | 
           3           | 2       | 10     | 5      | `null` | `null` | `null` |
           4           | 2       | 7      | 5      | 10     | `null` | `null` | 
           5           | 5       | 7      | 10     | `null` | `null` | `null` | 
           6           | 3       | 5      | 10     | 7      | `null` | `null` |
           7           | 3       | 5      | 10     | 7      | 12     | `null` |      
        </details>   

# Graph Implementation using C#

This project implements a weighted directed graph in C# to model a map of locations and calculate the shortest path betweeen two nodes. It demonstrates the use of graph data structure, JSON data parsing, and shortest path algorithms such as Dijkstra's algorithm in a practical, real-world context.

## Overview

The Graph Implementation project was developed as part of COIS 3020 - Data Structures & Algorithms II at Trent University. The goal of this project was to design a graph-based system capable of reading weighted edges from a JSON file, storing them efficiently using adjacency lists, and finding the shortest path between two given locations.

## Features

1. **Graph Data Structure**
   * Implemented using adjacency lists for efficient storage and traversal.
   * Each node represents a location and stores connected edges with travel time weights.
   * Supports dynamic creation and management of nodes and edges.
2. **Data Population**
   * Reads and parses a provided JSON file containing nodes and edges.
   * Automatically populates the graph structure with location and connection data.
   * Includes error handling for invalid or missing entries.
3. **Shortest Path Calculation**
   * Implements a shortest path algorithm (such as Dijkstra's Algorithm) to compute the shortest path between two nodes.
   * Displays both the path and the total travel time.
   * Handles disconnected nodes and non-existent paths gracefully.
4. **Program Driver**
   * Accepts user input for source and target locations.
   * Validates that both nodes exists in the graph before processing.
   * Displays a clear, step-by-step path from the start to the destination (if available).
5. **Testing**
   * Includes a testing.pdf document containing screenshots and description of all test cases.
   * Covers base cases, edge cases, and error-handling scenarios.
   * Demonstrates correctness and robustness of graph operations and shortest path logic.

## Code Structure

* **Graph.cs:** Defines the Node and Edge classes; implements adjacency list structure
* **GraphPopulater.cs:** Parses JSON data and populates the graph with nodes and weighted edges
* **GraphImplementation.cs:** Core graph functionality (add node, add edge, display, validate)
* **ShortestPath.cs:** Implements the shortest path algorithm, here Dijkstra's algorithm
* **Testing.pdf:** Contains screenshots and explanations of test results

## How to Use

1. Clone or download the repository.
2. Place the provided graph_data.json file.
3. Open the project in Visual Studio Code.
4. Build and run the application.
5. When prompted:
   * Enter the source location.
   * Enter the destination location.
   * View the shortest path and total travel time displayed in the console.

## Technical Skills Demonstrated

* **Programming Language:** C# (.NET environment)
* **Core Concepts:** Graph data structures, adjacency lists, weighted edges
* **Algorithm Design:** Dijkstra's shortest path algorithm
* **Data Handling:** JSON file parsing and validation
* **Error Handling:** Input validation and exception management
* **Testing & Documentation:** Screenshot-based functional testing with descriptive analysis
* **Code Organization:** Structured code with comments

## Purpose

This project was completed as part of COIS 3020 - Data Structures and Algorithms II at Trent University. It was designed to demonstrate practical applications of graph theory in route optimization problems and to strengthen proficiency in algorithm implementation, data structure design, and C# programming. The assignment was completed using Visual Studio Code (.NET environment). 
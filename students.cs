Name,Age,Math,Science,English,Attendance
Rahul,20,85,90,80,90
Priya,19,92,88,95,95
Amit,21,65,70,60,75
Sneha,20,88,92,90,98
Rohit,22,45,55,50,60
Anjali,19,95,96,94,99
Karan,21,72,68,75,80
Neha,20,80,85,88,90
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt

# Load dataset
df = pd.read_csv("students.csv")

# Display dataset
print(df)

# Display first five rows
print(df.head())

# Display last five rows
print(df.tail())

# Dataset information
print(df.info())

# Statistical summary
print(df.describe())

# Check number of rows and columns
print(df.shape)

# Check column names
print(df.columns)


# Check missing values
print(df.isnull().sum())

# Remove duplicate records
df = df.drop_duplicates()

# Fill missing numerical values with average
df["Math"] = df["Math"].fillna(df["Math"].mean())

# Check missing values again
print(df.isnull().sum())

# Check data types
print(df.dtypes)
# Calculate total marks
df["Total"] = df["Math"] + df["Science"] + df["English"]

# Calculate percentage
df["Percentage"] = df["Total"] / 3

# Calculate average using NumPy
average = np.mean(df["Percentage"])

# Find highest percentage
highest = np.max(df["Percentage"])

# Find lowest percentage
lowest = np.min(df["Percentage"])

# Find standard deviation
std_dev = np.std(df["Percentage"])

print("Average Percentage:", average)
print("Highest Percentage:", highest)
print("Lowest Percentage:", lowest)
print("Standard Deviation:", std_dev)

# Display updated dataset
print(df)
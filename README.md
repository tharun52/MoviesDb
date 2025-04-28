# Movie Sorter Application

## 📜 Overview

The **Movie Sorter** is a dynamic web application designed to help users search and sort movies based on various criteria such as title, release date, and user rating. It allows users to filter through a large collection of movies and choose sorting options for better user experience.

- **Features:**
  - **Search movies** by title.
  - **Sort movies** by title, release date, or user rating.
  - **Pagination** for browsing through large data sets.
  - **Sorting** available in ascending or descending order.

## 🛠️ How It Works

1. **Search Functionality**:  
   Users can search movies by typing into the search box. The list of movies is filtered dynamically as you type. This allows fast search results without page reloads.

2. **Sorting**:  
   Movies can be sorted by:
   - **Title** (alphabetically)
   - **Release Date** (chronologically)
   - **User Rating** (from low to high or high to low)
   
   Sorting options can be toggled between **ascending** and **descending** order. The movies are immediately re-ordered based on your selection.

3. **Pagination**:  
   When there are too many movies to display, pagination allows you to navigate through different pages of movie lists. You can click through the pages to view more content.

---

## 📁 Project Structure

```
MovieSorterApp/
│
├── Pages/
│   ├── Index.razor                # Main page of the application
│   ├── _Imports.razor             # Shared imports for Razor components
│   └── MovieCard.razor            # Movie card UI component
│
├── wwwroot/
│   ├── css/
│   │   └── style.css              # Styling for the movie card and layout
│   ├── images/
│   │   └── (Images for movie posters)
│
├── Data/
│   ├── MovieService.cs            # Movie data provider (handles movie fetching and sorting)
│   └── Models/
│       └── Movie.cs               # Movie model (includes properties like title, release date, rating, etc.)
│
└── _Host.cshtml                   # Main HTML layout
```

---

## 🖼️ Screenshot Output

You can insert a screenshot of the application output here:

![Output GIF](output.gif)

---

## 🚀 Usage

To use the **Movie Sorter Application**, follow these steps:

1. **Open the application**: Navigate to the web page where the app is hosted.
2. **Search for a movie**: Type the name of a movie in the search bar to filter the list.
3. **Choose sorting options**: Select from sorting by title, release date, or user rating, and toggle between ascending and descending order.
4. **Browse through pages**: Use the pagination controls to navigate between different sets of movies.


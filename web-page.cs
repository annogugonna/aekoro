/* CSS for AEKORO LLC Navigation Menu */

/* Basic Styling */
.navbar {
  background-color: #333;
  padding: 10px;
}

.navbar ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  display: flex;
  justify-content: center;
}

.navbar li {
  margin: 0 10px;
}

.navbar a {
  color: #fff;
  text-decoration: none;
  font-weight: bold;
  padding: 5px;
}

.navbar a:hover {
  color: #f00; /* Change the color on hover as desired */
}

/* Responsive Styling */
@media screen and (max-width: 768px) {
  .navbar {
    display: block;
  }

  .navbar ul {
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .navbar li {
    margin: 5px 0;
  }
}

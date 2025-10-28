import React from "react";


function App() {
// Scalar data
let storeName = "TechTrend Innovations";


// Array data
let categories = ["Electronics", "Accessories", "Gadgets", "Smart Home", "Wearables"];


// Object data
let storeInfo = {
location: "San Francisco, CA",
founded: 2023,
rating: 4.8,
};


// Array of objects data
let products = [
{ id: 1, name: "Wireless Earbuds", price: 59.99, category: "Electronics" },
{ id: 2, name: "Smart Watch", price: 199.99, category: "Gadgets" },
{ id: 3, name: "Phone Case", price: 19.99, category: "Accessories" },
{ id: 4, name: "Bluetooth Speaker", price: 89.99, category: "Electronics" },
{ id: 5, name: "Laptop Stand", price: 39.99, category: "Accessories" },
{ id: 6, name: "Smart Bulb", price: 24.99, category: "Smart Home" },
];


return (
<div>
{/* Page Header */}
<header>
<h1>{storeName}</h1>
<p>Welcome to our online store – your one-stop shop for tech gadgets and accessories!</p>
<hr />
</header>


{/* Categories Section */}
<section>
<h2>Product Categories</h2>
<ul>
{categories.map((category, index) => (
<li key={index}>{category}</li>
))}
</ul>
<hr />
</section>


{/* Store Information */}
<section>
<h2>Store Information</h2>
<p><strong>Location:</strong> {storeInfo.location}</p>
<p><strong>Founded:</strong> {storeInfo.founded}</p>
<p><strong>Rating:</strong> {storeInfo.rating} ⭐</p>
<hr />
</section>


{/* Products Section */}
<section>
<h2>Featured Products</h2>


{products.length > 0 ? (
<table border="1" cellPadding="10" cellSpacing="0">
<thead>
<tr>
<th>ID</th>
<th>Product Name</th>
<th>Price ($)</th>
<th>Category</th>
</tr>
</thead>
<tbody>
{products.map((product) => (
<tr key={product.id}>
<td>{product.id}</td>
<td>{product.name}</td>
<td>{product.price.toFixed(2)}</td>
<td>{product.category}</td>
</tr>
))}
</tbody>
</table>
) : (
<p>No products available.</p>
)}
<hr />
</section>


{/* Footer */}
<footer>
<p>© {new Date().getFullYear()} {storeName}. All rights reserved.</p>
</footer>
</div>
);
}


export default App;


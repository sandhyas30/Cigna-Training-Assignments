import React, { useState, useEffect } from "react";

function ProductTable1() {
  const [products, setProducts] = useState([]);
  const [pid, setPid] = useState("");
  const [pname, setPname] = useState("");
  const [price, setPrice] = useState("");
  const [error, setError] = useState("");

  useEffect(() => {
    setProducts([
      { pid: 101, pname: "Laptop", price: 50000 },
      { pid: 102, pname: "Mouse", price: 800 },
      { pid: 103, pname: "Keyboard", price: 1200 },
    ]);
  }, []);

  const validate = () => {
    if (!pid || pid < 1 || pid > 9999) {
      setError("❌ Product ID should be between 1 and 9999");
      return false;
    }
    if (!pname || pname.length <= 4) {
      setError("❌ Product Name must be more than 4 characters");
      return false;
    }
    if (!price || price <= 0) {
      setError("❌ Price must be greater than 0");
      return false;
    }
    setError("");
    return true;
  };

  const addProduct = () => {
    if (!validate()) return;

    const newProduct = {
      pid: parseInt(pid),
      pname,
      price: parseFloat(price),
    };
    setProducts([...products, newProduct]);
    setPid("");
    setPname("");
    setPrice("");
  };

  return (
    <div style={{ padding: "20px" }}>
      <h2>Product Management</h2>

      <div style={{ marginBottom: "20px" }}>
        <input
          type="number"
          placeholder="Product ID"
          value={pid}
          onChange={(e) => setPid(e.target.value)}
        />
        <input
          type="text"
          placeholder="Product Name"
          value={pname}
          onChange={(e) => setPname(e.target.value)}
        />
        <input
          type="number"
          placeholder="Price"
          value={price}
          onChange={(e) => setPrice(e.target.value)}
        />
        <button onClick={addProduct}>Add Product</button>
      </div>

      {error && <p style={{ color: "red" }}>{error}</p>}

      <table border="1" cellPadding="10">
        <thead>
          <tr>
            <th>Product ID</th>
            <th>Name</th>
            <th>Price (₹)</th>
          </tr>
        </thead>
        <tbody>
          {products.map((p) => (
            <tr key={p.pid}>
              <td>{p.pid}</td>
              <td>{p.pname}</td>
              <td>{p.price}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default ProductTable1;

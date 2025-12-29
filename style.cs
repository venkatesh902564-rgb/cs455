* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, Helvetica, sans-serif;
}

body {
    background-color: #f4f6f8;
    color: #333;
}

/* Header */
header {
    background-color: #1565c0;
    color: white;
    text-align: center;
    padding: 2rem 1rem;
}

header h1 {
    font-size: 2.3rem;
}

header p {
    margin-top: 0.5rem;
    font-size: 1.1rem;
}

/* Cards */
.card {
    max-width: 900px;
    background: white;
    margin: 1.5rem auto;
    padding: 1.5rem;
    border-radius: 8px;
    box-shadow: 0 4px 10px rgba(0,0,0,0.1);
}

.card h2 {
    color: #1565c0;
    margin-bottom: 1rem;
}

/* Education */
.edu {
    margin-bottom: 1rem;
}

/* Skills */
.skills {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
}

.skills span {
    background-color: #1565c0;
    color: white;
    padding: 8px 16px;
    border-radius: 20px;
    font-size: 0.9rem;
}

/* Footer */
footer {
    text-align: center;
    padding: 1rem;
    background-color: #222;
    color: white;
    margin-top: 2rem;
}

/* Responsive */
@media (max-width: 600px) {
    header h1 {
        font-size: 1.8rem;
    }

    .card {
        margin: 1rem;
        padding: 1.2rem;
    }
}

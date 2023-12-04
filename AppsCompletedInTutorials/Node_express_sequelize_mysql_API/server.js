const express = require('express')
const cors = require('cors')
/*
Cross-Origin Resource Sharing (CORS) is an HTTP-header based mechanism 
that allows a server to indicate any origins (domain, scheme, or port) 
other than its own from which a browser should permit loading resources.
*/

const app = express()

var corOptions = {
    origin: 'https://localhost:8081'
}

// middleware
app.use(cors(corOptions))
app.use(express.json())
app.use(express.urlencoded({ extended: true }))

// routers
const require = require('/routes/productRouter.js')
app.use('/api/products', router)
    //app.use('/api/comments', router)

//testing api
app.get('/', (req, res) => {
    res.json({ message: 'hello from api'})
})

//port
const PORT = process.env.PORT || 8080

//server
app.listen(PORT, ()=> {
    console.log('server is running on port ${PORT}')
})



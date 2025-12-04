import express from "express";
import nodemailer from 'nodemailer'
import { config } from "dotenv";

config()
const app = express()
const PORT = process.env.PORT
const EMAIL = process.env.EMAIL
const PASS = process.env.PASS

// Check if email credentials exist
if (!EMAIL || !PASS) {
    console.error('ERROR: EMAIL and PASS environment variables are required!');
}

app.use(express.json())

//validation middleware
function validateInput(req, res, next) {
    const { name, email } = req.body

    // Checking if the name and email exist
    if (!name || !email) {
        return res.status(400).json({
            error: 'Name and Email are required'
        })
    }

    // email validation using regex
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/
    if (!emailRegex.test(email)) {
        return res.status(400).json({
            error: 'Please provide a valid email address'
        })
    }
    // if validation passes move to the next middleware
    next()
}

// Setting up the nodemailer transporter
function createTransporter() {
    return nodemailer.createTransport({
        host: 'smtp.ethereal.email',
        port: 587,
        secure: false, // Added this for clarity
        auth: {
            user: EMAIL,
            pass: PASS
        }
    })
}

// api
app.post('/send-welcome-email', validateInput, async (req, res) => {
    try {
        const { name, email } = req.body;
        
        // Check if credentials are available
        if (!EMAIL || !PASS) {
            return res.status(500).json({
                success: false,
                error: 'Email service not configured. Please check server settings.'
            });
        }
        
        // Creating the transporter
        const transporter = createTransporter();
        
        // Setting up email content
        const mailOptions = {
            from: `"Welcome Team" <${EMAIL}>`, // Use your actual email
            to: email,
            subject: `Welcome, ${name}!`,
            text: `Hi ${name},\n\nWelcome to our platform! We're excited to have you.\n\nBest,\nThe Team`,
            html: `<h1>Hi ${name}!</h1>
                   <p>Welcome to our platform! We're excited to have you.</p>
                   <p><strong>Best,</strong><br>The Team</p>`
        };
        
        // Sending the email
        const info = await transporter.sendMail(mailOptions);
        
        // Return success response
        res.status(200).json({
            success: true,
            message: `Welcome email sent to ${email}`,
            messageId: info.messageId,
            previewUrl: nodemailer.getTestMessageUrl(info) // This gives you Ethereal preview link!
        });
        
    } catch (error) {
        // Handle any errors that occur during email sending
        console.error('Email error:', error);
        res.status(500).json({
            success: false,
            error: 'Failed to send email. Please try again later.'
        });
    }
});

// Health check endpoint
app.get('/', (req, res) => {
    res.json({
        message: 'Welcome Email API is running',
        endpoints: {
            sendEmail: 'POST /send-welcome-email',
            exampleRequest: {
                name: 'John Doe',
                email: 'john@example.com'
            }
        }
    });
});

// Finally, start the server
app.listen(PORT, () => {
    console.log(`Server running on port ${PORT}`);
});
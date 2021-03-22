const mongoose = require('mongoose')

const FormSchema = new mongoose.Schema({
    status:{
        type:String,
        default:'Pending'
    },
    firstName:{
        type:String
    },
    middleName:{
        type:String
    },
    lastName:{
        type:String
    },
    faculty:{
        type:String
    },
    facultyNumber:{
        type:String
    },
    lnch:{
        type:String
    },
    egn:{
        type:String
    },
    subject:{
        type:String
    },
    course:{
        type:String
    },
    textField:{
        type:String
    },
    startYear:{
        type:String,
    },
    lastYear:{
        type:String
    },
    term:{
        type:String
    },
    studyForm:{
        type:String
    },
    degree:{
        type:String
    },
    reason:{
        type:String
    },
    studentType:{
        type:String
    },
    discount:{
        type:String
    },
    
    user:{
        type: 'ObjectId',
        ref: 'User'
    }

})

module.exports = mongoose.model('Form',FormSchema);
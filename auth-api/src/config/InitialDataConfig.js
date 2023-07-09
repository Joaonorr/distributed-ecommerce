import bcrypt from 'bcrypt';
import User from '../models/UserModel.js';

export const CreateInitialData = async () => {
    console.log('Creating initial data...');

    await User.sync({ force: true });

    let password = await bcrypt.hash('123456', 10);

    let newUser = {
        userName: 'Admin',
        email: 'admin@admin.com',
        password: password
    };

    try {
        await User.create(newUser);
    }
    catch (error) {
        console.log(error);
    }
}

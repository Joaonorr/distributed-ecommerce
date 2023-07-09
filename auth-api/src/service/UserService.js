import UserRepository from "../repository/UserRepository.js";
import bcrypt from 'bcrypt';
import jwt from 'jsonwebtoken';
import dotenv from 'dotenv';

dotenv.config();

/**
 * @class UserService
 * @description Classe responsável por implementar as regras de negócio da entidade User
 * @exports UserService
 * @access public
 * @version 1.0.0
 */
class UserService {

    async findByEmail(req, res) {

        const { email } = req.body;

        if (!email) {
            return res.status(400).json({ message: 'Email is required' });
        }

        try {
                
            const user = await UserRepository.findByEmail(email);

            if (user) {

                return res.status(200).json({
                    id: user.id,
                    userName: user.userName,
                    email: user.email,
                    createdAt: user.createdAt,
                });

            }

            return res.status(404).json({ message: 'User not found' });

        } catch (error) {

            return res.status(500).json({ message: error.message });

        }
    }

    async findById(req, res) {

        const { id } = req.params;

        if (!id) {
            return res.status(400).json({ message: 'Id is required' });
        }

        try {
                
            const user = await UserRepository.findById(id);

            if (user) {

                return res.status(200).json({
                    id: user.id,
                    userName: user.userName,
                    email: user.email,
                    createdAt: user.createdAt,
                });

            }

            return res.status(404).json({ message: 'User not found' });

        } catch (error) {

            return res.status(500).json({ message: error.message });

        }
    }

    async getAuthToken(req, res) {

        const { email, password } = req.body;

        if (!email || !password) {

            return res.status(400).json({ message: 'Email and password are required' });

        }

        try {
                
            const user = await UserRepository.findByEmail(email);

            if (!user) {

                return res.status(404).json({ message: 'User not found' });

            }

            if (await bcrypt.compare(password, user.password)) {

                const authUser = {
                    id: user.id,
                    userName: user.userName,
                    email: user.email,
                    createdAt: user.createdAt,
                }

                const token = jwt.sign({authUser}, process.env.API_SECRETE, {expiresIn: '1h',});

                return res.status(200).json({ token: token });

            }

            return res.status(401).json({ message: 'Invalid password' });
    
        }
        catch (error) {
                
            return res.status(500).json({ message: error.message });
    
        }

    }



}

export default new UserService();